using System;
namespace ControlEntity.DataTransferObjects
{
    public class InventarioDtos
    {
        public class ExistenciasCantidad
        {
            public decimal CantidadTotal { get; set; }
        }

        public class ProdListSearch
        {
            public int Id { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }
    }

    public class ProveeduriaDtos
    {
        public class ProvListSearch
        {
            public int Pos { get; set; }
            public string Descripcion { get; set; }
            //public ProvListSearch()
            //{

            //}
            //public ProvListSearch(int pos, string descripcion)
            //{
            //    Pos = pos;
            //    Descripcion = descripcion;
            //}
        }
        public class ProveedorProductos
        {
            public int IdProducto { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
        }
    }

    public class VentasDtos
    {
        public class VentasQuery {
            public int Consecutivo { get; set; }
            public DateTime Fecha { get; set; }
            public int Caja { get; set; }
            public string Cajero { get; set; }
            public decimal Total { get; set; }
        }

        public class VentasComprobanteDetalle
        {
            public string Descripcion { get; set; }
            public decimal Cantidad { get; set; }
            public decimal Precio { get; set; }
            public Nullable<decimal> TotalLinea { get; set; }
            public decimal Descuento { get; set; }
            public decimal Impuesto { get; set; }
        }

        public class VentasCaja
        {
            public int IdCaja { get; set; }
        }

        public class PagosCaja
        {
            public string FormaPago { get; set; }
        }



    }

    public class CreditoDtos { 
        public class ClienteListSearch
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
    }

    public class GeneralDtos
    {
        public class RedondeoList
        {
            public string Redondeo { get; set; }
        }
    }

}
