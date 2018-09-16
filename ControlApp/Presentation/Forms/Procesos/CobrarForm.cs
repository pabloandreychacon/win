using ControlBusiness.Business;
using ControlBusiness.BusinessHelpers;
using BaseForms.Forms;
using System;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class CobrarForm : Basic
    {
        int consecutivo = 0;
        decimal total = 0;
        VentasB ventBL = new VentasB();

        public CobrarForm()
        {
            InitializeComponent();
        }

        public CobrarForm(int pConsecutivo, decimal pTotal)
        {
            InitializeComponent();
            consecutivo = pConsecutivo;
            total = pTotal;
        }

        private void CobrarForm_Load(object sender, EventArgs e)
        {
            this.txtPaga.TextChanged +=
                new EventHandler(txtPaga_TextChanged);
            txtTotal.Text = String.Format("{0:C}", total);
        }

        private void txtPaga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCambio.Text = String.Format("{0:C}",
                    (Convert.ToDecimal(txtPaga.Text) - total));
            }
            catch (Exception ex)
            {
                txtCambio.Text = ex.Message;
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (txtPaga.Text != "")
            {
                DialogResult _Resp = new DialogResult();
                _Resp = MessageBox.Show("¿Desea imprimir el comprobante?",
                    "Comprobante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (_Resp == DialogResult.Yes)
                {
                    //Imprmmir el ticket
                    Tickets.GenerarTicket(ventBL.GetVentaByConsecutivo(consecutivo), consecutivo);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe introducir una cantidad",
                    "Faltan datos");
            }
        }
    }
}
