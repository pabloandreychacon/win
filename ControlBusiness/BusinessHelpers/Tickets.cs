using ControlBusiness.Business;
using BaseHelpers.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlBusiness.BusinessHelpers
{
    public class Tickets
    {
        public static void GenerarTicket(int idVenta, int consecutivo)
        {
            GenerarTicket(idVenta, consecutivo, true);
        }
        public static void GenerarTicket(int idVenta, int consecutivo, bool preview)
        {
            VentasB ventBL = new VentasB();
            GeneralB genB = new GeneralB();
            try
            {
                var encabezado = ventBL.ConsultaEncabezado(idVenta);
                string printText =
                    ConfigurationManager.AppSettings["NombreNegocio"].ToUpper() + "\n" +
                    "Cedula: " + ConfigurationManager.AppSettings["Cedula"] + "\n" +
                    "Tel: " + ConfigurationManager.AppSettings["Telefono"] + "\n" +
                    "Fecha: " + encabezado.Fecha.ToShortDateString() + " " + encabezado.Fecha.ToLongTimeString() + "\n" +
                    "Factura: " + consecutivo.ToString() + "\n" +
                    "------------------------------\n" +
                    "ARTICULO                      \n" +
                    " CANT      PRECIO        TOTAL\n" +
                    "------------------------------\n";
                // trae detalle
                string detalleTicket = "";
                //decimal TotalFinal = 0;
                //decimal TotalDescuento = 0;
                //decimal TotalImpuesto = 0;
                decimal TotalFinal = encabezado.TotalVenta;
                decimal TotalDescuento = encabezado.TotalDescuentos;
                decimal TotalImpuesto = encabezado.TotalImpuestos;
                var detalle = ventBL.ConsultaDetalle(idVenta);
                foreach (var item in detalle)
                {
                    detalleTicket +=
                        (item.Descripcion.Length > 30 ? item.Descripcion.Substring(0, 30) : item.Descripcion.PadRight(30, ' ')) +
                        "\n" +
                        String.Format("{0,5:N0}", item.Cantidad) +
                        String.Format("{0,12:N1}", item.Precio) +
                        String.Format("{0,13:N1}", item.Cantidad * item.Precio) + "\n";
                    //TotalFinal += item.TotalLinea;
                    //TotalDescuento += item.Descuento;
                    //TotalImpuesto += item.Impuesto;
                }
                /// los totales guardados en el encabezado ya tienen el redondeo aplicado
                //detalleTicket +=
                //    "------------------------------\n" +
                //    "Descuento: " + String.Format("{0,19:N1}", 
                //        Tools.Redondeo.ApplyRound(TotalDescuento, localRedondeo)) + "\n" +
                //    "Impuestos: " + String.Format("{0,19:N1}", 
                //        Tools.Redondeo.ApplyRound(TotalImpuesto, localRedondeo)) + "\n" +
                //    "Total: " + String.Format("{0,23:N1}", 
                //        Tools.Redondeo.ApplyRound(TotalFinal, localRedondeo));
                detalleTicket +=
                    "------------------------------\n" +
                    "Descuento: " + String.Format("{0,19:N1}", TotalDescuento) + "\n" +
                    "Impuestos: " + String.Format("{0,19:N1}", TotalImpuesto) + "\n" +
                    "Total: " + String.Format("{0,23:N1}", TotalFinal);
                printText += detalleTicket;
                Printing _printDocument =
                    new Printing(printText);
                if (preview)
                {
                    _printDocument.PrintPreview();
                }
                else
                {
                    _printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                ControlBusiness.BusinessHelpers.General.DoError(ex, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
