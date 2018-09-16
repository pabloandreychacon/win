using ControlBusiness.Business;
using ControlBusiness.BusinessEntities;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using ControlEntity;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class AjusteInventarioForm : Basic
    {        
        /// fields        
        CommonB commB = new CommonB();
        InventarioB inventBL = new InventarioB();
        DetalleAjustes detailAjustes = new DetalleAjustes();

        /// properties
        public AjusteInventarioForm()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (ValidaAjuste())
            {
                if (detailAjustes.ComputeTotalValue() > 0)
                {
                    //int consecutivo = SaveAjusteNewContext();
                    int consecutivo = SaveAjusteCurrentContext();
                    if (consecutivo != 0)
                    {
                        //PrintCurrentAjuste(consecutivo);
                        SetForm();
                    }
                }
            }
            else
            {
                lblMensaje.Text = "No hay detalle de factura.";
            }           
        }

        private void SetForm()
        {
            detailAjustes.Clear();
            gridDetalle.DataSource = null;
            //txtConsecutivo.Text = GetConsecutivo(false);
            //txtTotal.Text = "0";
            txtExistencia.Text = "";
            txtPrecio.Text = "0";
            //txtCodigoProducto.Text = "";
            txtCodigoProducto.Select(0, txtCodigoProducto.Text.Length);
            txtDescripcion.Text = "";
            rdoEntrada.Checked = true;
            lblMensaje.Text = "";
            rdoEntrada.Focus();
        }

        /// <summary>
        /// usa un context general un nuevo control context para hacer la transaction
        /// hace llamdos a metodos del inventBL que a su vez usa el mismo context
        /// </summary>
        /// <returns></returns>
        private int SaveAjusteCurrentContext()
        {
            var continuar = true;
            var consecutivo = 1;
            /// current context
            /// usamos el de invent porque solo esas tablas se modifican
            /// por el momento no hay un context general para todos nucleos
            /// podria ponerse en una interface padre
            ////var context = inventBL.dbCtx;
            /// inicio la transaction con el context actual
            //using (var dbcxtransaction = context.Database.BeginTransaction())
            commB.BeginTran();
            {
                try
                {
                    foreach (var item in detailAjustes.AjustesLines)
                    {
                        var producto = inventBL.GetProductoById(item.IdProducto);
                        if (producto != null)
                        {
                            /// actualizar costo: get costo
                            producto.PrecioVenta = item.Precio;
                            commB.UpdateEntity<Producto>(producto);
                            /// solo para los q tienen existencia, para los demas no se acualiz su existencia
                            if (producto.VerificaDisponible)
                            {
                                var existencia = inventBL.GetExistenciaByIdProducto(item.IdProducto);
                                var cantidad = item.Cantidad;
                                if (rdoSalida.Checked) cantidad = cantidad * -1;
                                if (existencia != null)
                                {
                                    if (existencia.Cantidad + cantidad >= 0)
                                    {
                                        inventBL.UpdateExistencia(existencia, cantidad);
                                        commB.Commit();
                                    }
                                    else
                                    {
                                        commB.Rollback();
                                        commB.Reload(producto);
                                        lblMensaje.Text = "El producto " + item.Descripcion +
                                            " no puede tener existencias negativas.";
                                        continuar = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    var newExist = inventBL.InsertExistencia(item.IdProducto, cantidad);
                                    ///dbcxtransaction.Commit();
                                    commB.Commit();
                                }
                            }
                        }
                        else
                        {
                            ///dbcxtransaction.Rollback();
                            commB.Rollback();
                            lblMensaje.Text = "El producto " + item.Descripcion +
                                " no existe en el inventario";
                            continuar = false;
                            break;
                        }
                    }
                    if (!continuar) return 0;
                    MessageBox.Show("Ajuste aplicado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    return (consecutivo);
                }
                catch (Exception ex)
                {
                    ///dbcxtransaction.Rollback();
                    commB.Rollback();
                    ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return (0);
                }
            }
        }         

        private void AjusteInventarioForm_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Tools.UserCredentials.UserName;
        }

        private void AjusteInventarioForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                okButton1.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                this.btnBuscaProducto.PerformClick();
            }
        }

        private bool ValidaAjuste()
        {
            bool isValid = false;
            if (detailAjustes.AjustesLines.Count() > 0) isValid = true;
            return isValid;
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var productsList = inventBL.GetProductoSearch();
                if (productsList != null && productsList.Count() > 0)
                {
                    //DataTable searchTable = new DataTable();
                    var searchTable = productsList.AsDataTable(); // transforma en dataTable
                    var searchForm = new Search(searchTable, "Codigo, Descripcion", "Codigo");
                    searchForm.ShowDialog();
                    this.txtCodigoProducto.Text = searchForm.SelectedKey;
                    ValidateProducto(txtCodigoProducto.Text.Trim());
                    //this.txtCantidad.Focus(); // hace que se valide el position text

                }
                else
                {
                    MessageBox.Show("No se encontraron los productos");
                    DisableButtons();
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCodigoProducto.Text = "";
            }
        }

        private void DisableButtons()
        {
            foreach (System.Windows.Forms.Control controlItem in Controls)
            {
                if (controlItem is TextBox) controlItem.Enabled = false;
            }
            btnBuscaProducto.Enabled = false;
            okButton1.Enabled = false;
        }

        private void txtCodigoProducto_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateProducto(this.txtCodigoProducto.Text.Trim()))
            {
                e.Cancel = true;
                errorContainer1.errorProvider1.SetError(txtCodigoProducto, "Producto incorrecto");
                txtCodigoProducto.Select(0, txtCodigoProducto.Text.Length);
                txtCodigoProducto.Focus();
            }
        }

        private bool ValidateProducto(string prod)
        {            
            var curProd = inventBL.GetProductoByCode(prod.Trim());
            if (curProd != null)
            {
                txtDescripcion.Text = curProd.Descripcion;
                var exist = inventBL.GetProductoExistencias(curProd.IdProducto);
                if (exist != null) { txtExistencia.Text = exist.CantidadTotal.ToString(); }
                else
                {
                    txtExistencia.Text = "0";
                }
                txtPrecio.Text = curProd.PrecioVenta.ToString();
                txtCantidad.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtCodigoProducto_Validated(object sender, EventArgs e)
        {
            errorContainer1.errorProvider1.Clear();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ValidateHeader())
                {
                    AddItemToCart(txtCodigoProducto.Text,
                        Convert.ToDecimal(txtCantidad.Text), Convert.ToDecimal(txtPrecio.Text));
                    txtCodigoProducto.Focus();
                }
            }
        }

        private void AddItemToCart(string prod, decimal quant, decimal price)
        {
            var curProd = inventBL.GetProductoByCode(prod);
            if (curProd != null)
            {
                //decimal? precioVenta = curProd.PrecioVenta;
                try
                {
                    detailAjustes.AddItem(curProd.IdProducto, txtDescripcion.Text.Trim(),
                        Convert.ToDecimal(txtExistencia.Text.Trim()),
                        quant, price, Math.Round(quant * price, 2));

                    txtCodigoProducto.SelectAll();
                    txtCantidad.Text = "1";
                    txtCodigoProducto.Focus();
                    DisplayCartData();
                }
                catch (Exception ex)
                {
                    ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void DisplayCartData()
        {
            lblMensaje.Text = "";
            //decimal totalFinal = 0M;
            try
            {
                // leer del carrito, si hay datos
                if (detailAjustes.AjustesLines.Count() > 0)
                {
                    //gridDetalle.Rows.Clear();
                    var gridData = from d in detailAjustes.AjustesLines
                                   select new
                                   {
                                       Codigo = d.IdProducto,
                                       Descripcion = d.Descripcion.PadRight(30, ' '),
                                       Existencia = d.Existencia,
                                       Cantidad = d.Cantidad,
                                       Precio = d.Precio,
                                       Total = d.Total
                                   };
                    gridDetalle.DataSource = gridData.ToList();
                    //foreach (var item in detailAjustes.AjustesLines)
                    //{
                    //    totalFinal += item.Cantidad * item.Precio;
                    //}
                }
                else
                {
                    gridDetalle.DataSource = null;
                }
                //txtTotal.Text = String.Format("{0}", totalFinal);
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private bool ValidateHeader()
        {
            lblMensaje.Text = "";
            var validated = false;
            try
            {
                if (!(string.IsNullOrEmpty(txtCodigoProducto.Text)) ||
                    (string.IsNullOrEmpty(txtCantidad.Text)) ||
                    (string.IsNullOrEmpty(txtPrecio.Text)))
                {
                    var curProd = inventBL.GetProductoByCode(txtCodigoProducto.Text.Trim());
                    if (Tools.NumericValidators.IsPositiveNumeric(txtCantidad.Text) &&
                        Tools.NumericValidators.IsPositiveNumeric(txtPrecio.Text))
                    {
                        var numericQuantity = Convert.ToDecimal(txtCantidad.Text.Trim());
                        var numericPrice = Convert.ToDecimal(txtPrecio.Text.Trim());
                        if (curProd != null && numericQuantity > 0 && numericPrice > 0)
                        {
                            validated = true;
                        }
                        else
                        {
                            lblMensaje.Text = "Debe introducir una " +
                                "clave de producto y/o una cantidad y/o un precio válidos";
                            validated = true;
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "La cantidad o el precio es incorrecto";
                        validated = false;
                    }
                }
                else
                {
                    lblMensaje.Text = "Debe introducir una " +
                        "clave de producto y/o una cantidad y/o un precio";
                    validated = true;
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return validated;
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateHeader())
            {
                AddItemToCart(txtCodigoProducto.Text,
                    Convert.ToDecimal(txtCantidad.Text), Convert.ToDecimal(txtPrecio.Text));
                txtCodigoProducto.Focus();
            }
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            /// no se puede sacar mas de lo que hay
            if (rdoSalida.Checked)
            {
                if (Convert.ToDecimal(txtExistencia.Text) > 0 && 
                    Convert.ToDecimal(txtExistencia.Text) < Convert.ToDecimal(txtCantidad.Text))
                {
                    e.Cancel = true;
                    errorContainer1.errorProvider1.SetError(txtCantidad, "Cantidad incorrecto");
                    txtCantidad.Select(0, txtCantidad.Text.Length);
                    txtCantidad.Focus();
                }
            }
        }
    }
}
