using ControlBusiness.Business;
using BaseForms.Forms;
using System;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Consultas
{
    public partial class Ventas : Basic
    {
        VentasB ventBL = new VentasB();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Headers()
        {
            lstVentas.View = View.Details;
            lstVentas.Columns.Add("Consecutivo", 90, HorizontalAlignment.Left);
            lstVentas.Columns.Add("Fecha", 155, HorizontalAlignment.Left);
            lstVentas.Columns.Add("Caja", 50, HorizontalAlignment.Center);
            lstVentas.Columns.Add("Cajero", 150, HorizontalAlignment.Left);
            lstVentas.Columns.Add("Total", 125, HorizontalAlignment.Right); 
        }

        private void ReadData()
        {
            //Este procedimiento lee los datos 
            //que se tranferirán y los mostrará en forma de
            //lista en el ListView   
            try
            {
                var ventas = ventBL.ConsultaVentas();
                double total = 0;
                int i = 0;
                lstVentas.Items.Clear();
                foreach (var item in ventas)
                {
                    lstVentas.Items.Add(item.Consecutivo.ToString());
                    lstVentas.Items[i].SubItems.Add(item.Fecha.ToString());
                    lstVentas.Items[i].SubItems.Add(item.Caja.ToString());
                    lstVentas.Items[i].SubItems.Add(item.Cajero.ToString());
                    lstVentas.Items[i].SubItems.Add(String.Format("{0:C}", item.Total));
                    total += Convert.ToDouble(item.Total);
                    i += 1;
                }
                
                //Agregamos un registro más
                if (i != 0)
                {
                    lstVentas.Items.Add("");
                    lstVentas.Items[i].SubItems.Add("");
                    lstVentas.Items[i].SubItems.Add("");
                    lstVentas.Items[i].SubItems.Add("Gran Total:");
                    lstVentas.Items[i].SubItems.Add(String.Format("{0:C}", total));
                }
            }
            catch (Exception ex)
            {               
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            Headers();
            ReadData();
        }
    }
}
