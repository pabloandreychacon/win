using ControlEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlBusiness.BusinessEntities
{
    public class DetalleFactura
    {
        private List<DetalleLine> lineCollection = new List<DetalleLine>();

        public void AddItem(Producto producto, decimal cantidad)
        {
            AddItem(producto, cantidad, 0);
        }

        public void AddItem(Producto producto, decimal cantidad, decimal montoDescuento)
        {
            DetalleLine line = lineCollection.Where(
                p => p.Producto.IdProducto == producto.IdProducto).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new DetalleLine
                {
                    Producto = producto,
                    Cantidad = cantidad,
                    MontoDescuento = Math.Round( cantidad * (producto.PrecioVenta * producto.Descuento / 100),2)
                });
            }
            else
            {
                line.Cantidad += cantidad;
                line.MontoDescuento += montoDescuento;
            }
        }

        public void RemoveLine(Producto product)
        {
            lineCollection.RemoveAll(l => l.Producto.IdProducto == product.IdProducto);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Producto.PrecioVenta * Convert.ToDecimal(e.Cantidad));
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<DetalleLine> CartLines
        {
            get { return lineCollection; }
        }

    }

    public class DetalleLine
    {
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal MontoDescuento { get; set; }
    }
}
