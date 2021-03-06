//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Creditos = new HashSet<Credito>();
            this.Ventas = new HashSet<Venta>();
        }
    
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Contado { get; set; }
        public decimal MontoMaximo { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> IdFrecuenciaPago { get; set; }
    
        public virtual FrecuenciasPago FrecuenciasPago { get; set; }
        public virtual ICollection<Credito> Creditos { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
