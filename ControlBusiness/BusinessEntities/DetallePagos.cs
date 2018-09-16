using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBusiness.BusinessEntities
{
    public class DetallePagos
    {
        private List<PagosLine> lineCollection = new List<PagosLine>();

        public void AddItem(string formaPago, string documento,
            int banco, int tarjeta, decimal montoTotal, 
            decimal montoPagado, decimal montoAplicado, decimal montoCambio,
            int linea, int frecuencia, int cuotas)
        {
            PagosLine line = lineCollection.Where(
                p => p.FormaPago == formaPago && p.Documento == documento && 
                    p.Banco == banco && p.Tarjeta == tarjeta).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new PagosLine
                {
                    FormaPago=formaPago,
                    MontoTotal=montoTotal,
                    Documento=documento,
                    Banco=banco,
                    Tarjeta=tarjeta,
                    MontoPagado=montoPagado,
                    MontoAplicado=montoAplicado,
                    MontoCambio=montoCambio,
                    Linea=linea,
                    Frecuencias=frecuencia,
                    Cuotas = cuotas
                });
            }
            else
            {
                /// esta parte no se debe ejecutar 
                /// si no se permite repetir formas de pago
                /// si se puede mientras no sea efectivo o cheque repetido o tarjeta repetida
                line.MontoPagado += montoPagado;
                line.MontoAplicado += montoAplicado;
                line.MontoTotal += montoTotal;
                line.MontoCambio += montoCambio;
            }
        }

        public void RemoveLine(string formaPago)
        {
            lineCollection.RemoveAll(l => l.FormaPago == formaPago);
        }

        public decimal ComputeTotalValueMontoPagado()
        {
            return lineCollection.Sum(e => e.MontoPagado);
        }

        public decimal ComputeTotalValueMontoCambio()
        {
            return lineCollection.Sum(e => e.MontoCambio);
        }

        public decimal ComputeTotalValueMontoTotal()
        {
            return lineCollection.Sum(e => e.MontoTotal);
        }

        public decimal ComputeTotalValueMontoAplicado()
        {
            return lineCollection.Sum(e => e.MontoAplicado);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<PagosLine> PagosLines
        {
            get { return lineCollection; }
        }
    }

    public class PagosLine
    {
        public string FormaPago { get; set; }
        public decimal MontoTotal { get; set; }
        public string Documento { get; set; }
        public int Banco { get; set; }
        public int Tarjeta { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal MontoAplicado { get; set; }
        public decimal MontoCambio { get; set; }
        public int Linea { get; set; }
        public int Frecuencias { get; set; }
        public int Cuotas { get; set; }
    }
}
