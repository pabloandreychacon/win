using ControlBusiness.Business;
using BaseForms.Forms;
using BaseHelpers.Helpers;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class NotaDebitoCreditoForm : Basic
    {
        InventarioB inventBL = new InventarioB();
        CommonB genB = new CommonB();

        public NotaDebitoCreditoForm()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (!ValidaAjuste()) return;
            try
            {
                bool continuar = true;
                var producto = inventBL.GetProductoByCode(txtCodigoProducto.Text.Trim());
                var existencia = inventBL.GetProductoExistencias(producto.IdProducto);
                if (producto != null)
                {
                    var precioUnitario = 0m;
                    genB.BeginTran();
                    var montoAjuste = Convert.ToDecimal(txtMontoAjuste.Text) * (rdoDebito.Checked ? 1 : -1);
                    if (existencia.CantidadTotal > 0)
                    {
                        precioUnitario = ((producto.PrecioUnitario * existencia.CantidadTotal) + montoAjuste) / existencia.CantidadTotal;
                        if (precioUnitario < 0)
                        {
                            lblMensaje.Text = "El monto del ajuste es mayor al costo de todos los productos";
                            continuar = false;
                        }
                    }
                    else
                    {
                        if (montoAjuste > 0)
                        {
                            precioUnitario = montoAjuste;
                        }
                        else
                        {
                            lblMensaje.Text = "No se puede aplicar una nota de crédito a un producto sin existencia.";
                            continuar = false;
                        }
                    }
                    if (continuar)
                    {
                        producto.PrecioUnitario = precioUnitario;
                        genB.UpdateEntity<Producto>(producto);
                        genB.Commit();
                        SetForm();
                        MessageBox.Show("Proceso aplicado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        genB.Rollback();
                    }
                }
                else
                {
                    lblMensaje.Text = "No se puede aplicar una nota de crédito a un producto sin existencia.";
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
            }   
        }

        private void NotaDebitoCreditoForm_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Tools.UserCredentials.UserName;
        }

        private void NotaDebitoCreditoForm_KeyDown(object sender, KeyEventArgs e)
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
            bool isValid = true;
            if (string.IsNullOrEmpty(txtCodigoProducto.Text)) { 
                isValid = false;
                errorContainer1.errorProvider1.SetError(txtCodigoProducto, "Producto incorrecto");
                txtCodigoProducto.Select(0, txtCodigoProducto.Text.Length);
                txtCodigoProducto.Focus();
            }
            if (string.IsNullOrEmpty(txtMontoAjuste.Text))
            {
                isValid = false;
                errorContainer1.errorProvider1.SetError(txtMontoAjuste, "Monto incorrecto");
                txtMontoAjuste.Select(0, txtMontoAjuste.Text.Length);
                txtMontoAjuste.Focus();
            }
            return isValid;
        }

        private void SetForm()
        {
            txtExistencia.Text = "";
            txtPrecioUnitario.Text = "0";
            //txtCodigoProducto.Text = "";
            txtCodigoProducto.Select(0, txtCodigoProducto.Text.Length);
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            rdoDebito.Checked = true;
            lblMensaje.Text = "";
            rdoDebito.Focus();
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

        private bool ValidateProducto(string prod)
        {
            var curProd = inventBL.GetProductoByCode(prod.Trim());
            if (curProd != null)
            {
                txtDescripcion.Text = curProd.Descripcion;
                var exist = inventBL.GetProductoExistencias(curProd.IdProducto);
                if (exist != null) 
                { 
                    txtExistencia.Text = exist.CantidadTotal.ToString(); 
                    txtCosto.Text = (exist.CantidadTotal * curProd.PrecioUnitario).ToString();
                }
                else
                {
                    txtExistencia.Text = "0";
                    txtCosto.Text = "0";
                }
                txtPrecioUnitario.Text = curProd.PrecioUnitario.ToString();
                txtMontoAjuste.Text = txtPrecioUnitario.Text;
                txtMontoAjuste.Focus();
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
    }
}
