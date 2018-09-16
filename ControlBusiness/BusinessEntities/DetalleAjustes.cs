using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBusiness.BusinessEntities
{
    public class DetalleAjustes
    {
        private List<AjusteLine> lineCollection = new List<AjusteLine>();

        public void AddItem(int codigoProducto, string descripcion, decimal existencia,
            decimal cantidad, decimal precio, decimal total)
        {
            AjusteLine line = lineCollection.Where(
                p => p.IdProducto == codigoProducto).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new AjusteLine
                {
                    IdProducto = codigoProducto,
                    Descripcion = descripcion,
                    Existencia = existencia,
                    Cantidad = cantidad,
                    Precio = precio,
                    Total = Math.Round(cantidad * precio, 2)
                });
            }
            else
            {
                /// esta parte no se debe ejecutar 
                /// si no se permite repetir formas de pago
                /// si se puede mientras no sea efectivo o cheque repetido o tarjeta repetida
                line.Cantidad += cantidad;
                line.Precio = precio;
                line.Total = Math.Round(line.Cantidad * line.Precio, 2);
            }
        }

        public void RemoveLine(int codigoProducto)
        {
            lineCollection.RemoveAll(l => l.IdProducto == codigoProducto);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Total);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<AjusteLine> AjustesLines
        {
            get { return lineCollection; }
        }
    }

    public class AjusteLine
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Existencia { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
    }
}
