using BaseHelpers.Helpers;
using ControlBusiness.BusinessEntities;
using System;
using System.Windows.Forms;
using BaseForms.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class AjusteLinea : Basic
    {
        public bool BorrarLinea;
        public DetalleLine cartLine;

        public AjusteLinea(DetalleLine line)
        {
            InitializeComponent();
            cartLine = line;
        }

        private void AjusteLinea_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = cartLine.Cantidad.ToString();
            txtProducto.Text = cartLine.Producto.Descripcion;
            txtMontoDescuento.Text = cartLine.MontoDescuento.ToString();
            txtPorcentajeDescuento.Text = Math.Round(
                (
                (cartLine.MontoDescuento / cartLine.Cantidad) / cartLine.Producto.PrecioVenta
                ) * (100), 2).ToString();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            /// validar campos
            if (Tools.NumericValidators.IsPositiveNumeric(txtMontoDescuento.Text) &&
                Tools.NumericValidators.IsPositiveNumeric(txtCantidad.Text) && 
                Tools.NumericValidators.IsPositiveNumeric(txtPorcentajeDescuento.Text))
            {
                SetMontoDescuento();
                if (!BorrarLinea) {
                    cartLine.MontoDescuento = Convert.ToDecimal(txtMontoDescuento.Text);
                    cartLine.Cantidad = Convert.ToDecimal(txtCantidad.Text);                
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos por favor verifique.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtCantidad.Focus();
            }
        }

        private void SetPorcentajeDescuento()
        {
            if (Tools.NumericValidators.IsPositiveNumeric(txtMontoDescuento.Text) &&
                Tools.NumericValidators.IsPositiveNumeric(txtCantidad.Text))
                txtPorcentajeDescuento.Text =
                    Math.Round(
                        (
                            Convert.ToDecimal(txtMontoDescuento.Text) /
                            Convert.ToDecimal(txtCantidad.Text) /
                            cartLine.Producto.PrecioVenta
                        ) * (100), 2).ToString();
        }

        private void SetMontoDescuento()
        {
            if (Tools.NumericValidators.IsPositiveNumeric(txtPorcentajeDescuento.Text) &&
                Tools.NumericValidators.IsPositiveNumeric(txtCantidad.Text))
                txtMontoDescuento.Text =
                    Math.Round
                    (
                        Convert.ToDecimal(txtCantidad.Text) *
                        (
                            cartLine.Producto.PrecioVenta *
                            (
                                Convert.ToDecimal(txtPorcentajeDescuento.Text) / 100
                            )
                        )
                    , 2).ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            BorrarLinea = true;
            okButton1.PerformClick();
        }

        private void txtMontoDescuento_Leave(object sender, EventArgs e)
        {
            SetPorcentajeDescuento();
        }

        private void txtPorcentajeDescuento_Leave(object sender, EventArgs e)
        {
            SetMontoDescuento();                                               
        }
    }
}
