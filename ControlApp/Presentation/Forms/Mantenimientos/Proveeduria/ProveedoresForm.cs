using ControlBusiness.Business;
using BaseHelpers.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using BaseForms.Forms;
using ControlEntity;

namespace ControlApp.Presentation.Forms.Mantenimientos
{
    public partial class ProveedoresForm : Maintenance
    {
        InventarioB prodBl = new InventarioB();
        ProveedoresB provBl = new ProveedoresB();
        CommonB commB = new CommonB();
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            try
            {
                var provListBind = commB.GetBindList<Proveedore>();//.ToList();

                proveedorBindingSource.DataSource = provListBind;
                proveedorBindingNavigator.BindingSource = proveedorBindingSource;

                if (provListBind.Count > 0)
                {
                    ControlBusiness.BusinessHelpers.LocalData.searchProvList = provBl.SetProvSearchList(provListBind.ToList()); // prepara busqueda
                }
                else
                {
                    btnFind.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            proveedorBindingSource.EndEdit();

            var selectedProveedor = commB.SetEntity<Proveedore>(proveedorBindingSource.Current);
            if (selectedProveedor != null) commB.UpdateEntity<Proveedore>(selectedProveedor);
            proveedorBindingSource.ResetBindings(true);
        }

        public override bool ValidateFields()
        {
            return Validator(descripcionTextBox, ValidationTypes.Text, "Debe digitar una descripcion válida.");
        }

        private void proveedorBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var curProv = commB.SetEntity<Proveedore>(proveedorBindingSource.Current);
            gridProductos.DataSource = provBl.GetProveedorProductos(curProv.IdProveedor);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (ControlBusiness.BusinessHelpers.LocalData.searchProvList != null && ControlBusiness.BusinessHelpers.LocalData.searchProvList.Count > 0)
            {
                var searchTable = ControlBusiness.BusinessHelpers.LocalData.searchProvList.AsDataTable(); // transforma en dataTable
                var searchForm = new Search(searchTable, OrderKeys, "Pos");
                searchForm.ShowDialog();

                this.bindingNavigatorPositionItem.Text = searchForm.SelectedKey;
                //productoBindingSource.Position = searchForm.SelectedKey; // int

                this.bindingNavigatorPositionItem.Focus();
                this.btnFind.Focus(); // hace que se valide el position text
            }
        }
    }
}
