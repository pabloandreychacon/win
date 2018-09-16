using System;
using ControlData;
using ControlData.Repository;
using ControlData.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Entity;
using ControlEntity.DataTransferObjects;
using ControlEntity;
using ControlData.DataRepository;

namespace ControlTests
{
    //class MockControlRepository : IInventario, IDisposable
    class MockControlRepository : CommonR
    {
        //ControlEntities dbCtx;

        public MockControlRepository(ControlEntities ctx) : base(ctx)
        {            
            dbCtx = ctx;
        }
        
        public ControlEntities db
        {
            get
            {
                return dbCtx;
            }
        }
        
        //private ControlEntities db = new ControlEntities(); // esto requirio que se agregara el package ensamblado con Nugget : EntityFramework 5
        List<Producto> productos = new List<Producto>();
        List<Proveedore> proveedor = new List<Proveedore>();
        List<Existencia> existencia = new List<Existencia>();
        public List<InventarioDtos.ProdListSearch> SetSearchList(List<Producto> prodListBinded) {
            var prodListLocal = new List<InventarioDtos.ProdListSearch>();

            for (int i = 0; i < prodListBinded.Count; i++)
            {
                prodListLocal.Add(new InventarioDtos.ProdListSearch
                {
                    Id = i + 1,
                    Codigo = prodListBinded[i].Codigo,
                    Descripcion = prodListBinded[i].Descripcion,
                    Precio = prodListBinded[i].PrecioVenta
                });
            }
            return prodListLocal;
        }
        
        public Producto SetProducto(object prod)
        {
            return (Producto)prod;
        }

        public List<InventarioDtos.ExistenciasCantidad> GetProductoExistencias(int prod)
        {
            var productosQuery = from e in existencia
                                 where e.IdProducto == prod
                                 select new InventarioDtos.ExistenciasCantidad { CantidadTotal = e.Cantidad };
            return productosQuery.ToList();
        }

        public BindingList<Producto> GetBindProductos()
        {
            db.Productos.OrderBy(p => p.IdProducto).Include("Existencias").Load();
            var prodBindList = db.Productos.Local.ToBindingList();
            return prodBindList;
        }

        public void InsertProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void DeleteProducto(Producto producto)
        {
            productos.Remove(producto);
        }

        //public new void UpdateProducto()
        //{
        //    //productos.Remove(origProducto);
        //    //productos.Add(producto);
        //}

        public void UpdateProducto(Producto producto)
        {
            //productos.Remove(origProducto);
            productos.Add(producto);
        }

        public IEnumerable<Proveedore> GetProveedorName(Producto producto)
        {
            return proveedor;
        }

        public void Dispose()
        {
            dbCtx.Dispose();
        }

        public IEnumerable<Producto> GetProductos()
        {
            return productos;
        }



        public List<InventarioDtos.ProdListSearch> GetProductoSearch()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Existencia> GetExistencias()
        {
            throw new NotImplementedException();
        }

        public BindingList<Existencia> GetBindExistencias()
        {
            throw new NotImplementedException();
        }
    }
}
