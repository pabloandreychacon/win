using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ControlData.Repository;
using System.Linq;

namespace ControlData.Repository.Interfaces
{
    /// <summary>
    /// para todos los repos
    /// </summary>
    public interface IControl 
    {
        /// abstracto y obligatorio to implement
        /// SetEntity maybe not
        E SetEntity<E>(E entity) where E : class;
        /// GetIEnumerable or GetList
        IEnumerable<E> GetList<E>() where E : class;
        /// GetBindList
        BindingList<E> GetBindList<E>() where E : class;
        /// InsertEntity
        void InsertEntity<E>(E entity) where E : class;
        /// DeleteEntity
        void DeleteEntity<E>(E entity) where E : class;
        /// UpdateEntity
        void UpdateEntity<E>(E entity) where E : class;
    }

    // una Interface por cada entidad de negocios ????
    public interface IInventario : IDisposable
    {
        // esta Interface es necesaria para hacer separacion de layers
        // deberia haber uno por cada entity: productos, existencias, proveedores, etc
        Producto SetProducto(object prov);
        IEnumerable<Producto> GetProductos();
        BindingList<Producto> GetBindProductos();
        void InsertProducto(Producto productos);
        void DeleteProducto(Producto productos);
        void UpdateProducto(Producto productos);
        IEnumerable<Proveedore> GetProveedorName(Producto producto);  // tabla relacionada, ver ejemplo en http://www.asp.net/web-forms/tutorials/continuing-with-ef/using-the-entity-framework-and-the-objectdatasource-control-part-2-adding-a-business-logic-layer-and-unit-tests
        // el repositorio debe heredar de esta interface:
        // public class ControlRepository : IDisposable, IControlRepository
        //ControlEntities db { get; }
        IEnumerable<Existencia> GetExistencias();
        BindingList<Existencia> GetBindExistencias();
    }

    public interface IProveedores : IDisposable
    {
        Proveedore SetProveedor(object prov);
        IEnumerable<Proveedore> GetProveedores();
        BindingList<Proveedore> GetBindProveedores();
        void UpdateProveedor(Proveedore proveedor);
    }

    public interface IGeneral : IDisposable
    {
        IEnumerable<Usuario> GetUsuario(string name, string pass);
        IEnumerable<Usuario> GetUsuarioById(int id);
        BindingList<Usuario> GetBindUsuarios();
        Usuario SetUsuario(object prov);
        void UpdateUsuario(Usuario usuario);
    }

    public interface IVentas : IDisposable
    {
        Venta GetNewVenta();
        DetalleVenta GetNewDetalleventa();
        BindingList<Caja> GetBindCajas();
        IQueryable<Caja> Cajas { get; }
    }

}
