using ControlBusiness.Business;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using ControlEntity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Mantenimientos
{
    public partial class ProductosForm : Maintenance
    {
        InventarioB inventB = new InventarioB();
        ProveedoresB provB = new ProveedoresB();
        CommonB commB = new CommonB();

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            try
            {
                var prodListBind = commB.GetBindList<Producto>();
                productoBindingSource.DataSource = prodListBind;
                productoBindingNavigator.BindingSource = productoBindingSource;

                if (prodListBind.Count > 0)
                {
                    ControlBusiness.BusinessHelpers.LocalData.prodSearchList = inventB.SetProdSearchList(prodListBind.ToList());
                }
                else
                {
                    btnFind.Enabled = false;
                }
                var provListBind = commB.GetBindList<Proveedore>();
                cboProveedores.DataSource = provListBind;
                cboProveedores.DisplayMember = "Descripcion";
                cboProveedores.ValueMember = "IdProveedor";
                cboProveedores.DataBindings.Add("SelectedValue", productoBindingSource, "IdProveedor", true);

                var catList = commB.GetList<Categoria>();
                cboCategorias.DataSource = catList;
                cboCategorias.DisplayMember = "Descripcion";
                cboCategorias.ValueMember = "IdCategoria";
                cboCategorias.DataBindings.Add("SelectedValue", productoBindingSource, "IdCategoria", true);

                var uniList = commB.GetList<UnidadesMedida>();
                cboUnidadesMedidas.DataSource = uniList;
                cboUnidadesMedidas.DisplayMember = "Descripcion";
                cboUnidadesMedidas.ValueMember = "IdUnidadMedida";
                cboUnidadesMedidas.DataBindings.Add("SelectedValue", productoBindingSource, "IdUnidadMedida", true);
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            productoBindingSource.EndEdit();

            var selectedProduct = commB.SetEntity<Producto>(productoBindingSource.Current);
            if (selectedProduct != null)
            {
                var selectedProveedor = commB.SetEntity<Proveedore>(cboProveedores.SelectedItem);
                var selectedCategory = commB.SetEntity<Categoria>(cboCategorias.SelectedItem);
                var selectedUnidad = commB.SetEntity<UnidadesMedida>(cboUnidadesMedidas.SelectedItem);

                selectedProduct.IdProveedor = selectedProveedor.IdProveedor;
                selectedProduct.IdCategoria = selectedCategory.IdCategoria;
                selectedProduct.IdUnidadMedida = selectedCategory.IdCategoria;
                //selectedProduct.PrecioVenta = selectedProduct.PrecioUnitario * (1 + selectedProduct.Utilidad / 100);
                commB.UpdateEntity<Producto>(selectedProduct);
            }
            productoBindingSource.ResetBindings(true);
        }

        private void productoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var curProd = commB.SetEntity<Producto>(productoBindingSource.Current);
            gridExistencias.DataSource = inventB.GetProductoExistenciasList(curProd.IdProducto);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripción válida.") &&
                   (Validator(codigoTextBox, ValidationTypes.Text, "Codigo no válido.") &&
                    Validator(cboProveedores, ValidationTypes.Text, "Proveedor no válido.")
                    && Validator(cboCategorias, ValidationTypes.Text, "Categoría no válida")
                    && Validator(cboUnidadesMedidas, ValidationTypes.Text, "Unidad de medida no válida"));
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (ControlBusiness.BusinessHelpers.LocalData.prodSearchList != null && ControlBusiness.BusinessHelpers.LocalData.prodSearchList.Count > 0)
            {
                var searchTable = ControlBusiness.BusinessHelpers.LocalData.prodSearchList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Id");
                searchForm.ShowDialog();

                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                //productoBindingSource.Position = searchForm.SelectedKey; // int

                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus(); // hace que se valide el position text
            }
        }

        private void utilidadTextBox_Leave(object sender, EventArgs e)
        {
            if (Tools.NumericValidators.IsPositiveNumeric(precioVentaTextBox.Text)
                && Tools.NumericValidators.IsPositiveNumeric(utilidadTextBox.Text))
            precioVentaTextBox.Text = Math.Round(
                (Convert.ToDecimal(precioUnitarioTextBox.Text) * 
                (1 + Convert.ToDecimal(utilidadTextBox.Text) / 100)), 2).ToString();
            //productoBindingNavigatorSaveItem.PerformClick();
        }

        private void precioVentaTextBox_Leave(object sender, EventArgs e)
        {
            if (Tools.NumericValidators.IsPositiveNumeric(precioVentaTextBox.Text)
                && Tools.NumericValidators.IsPositiveNumeric(precioUnitarioTextBox.Text))
                utilidadTextBox.Text =
                    Math.Round(
                        100 * (Convert.ToDecimal(precioVentaTextBox.Text) /
                        Convert.ToDecimal(precioUnitarioTextBox.Text) - 1)
                    , 2).ToString();
            //productoBindingNavigatorSaveItem.PerformClick();
        }
    }
}
