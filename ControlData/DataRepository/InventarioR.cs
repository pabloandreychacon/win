using ControlEntity.DataTransferObjects;
using ControlData.DataRepository.Abstract;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ControlData.Repository
{
    //public class InventarioR : IInventario
    public class InventarioR : ControlBase//, IControl
    {
        // ctors
        public InventarioR()
        {
        }

        public InventarioR(ControlEntities passedCtx) : base
            (passedCtx)
        {
        }

        #region productos
        public List<InventarioDtos.ProdListSearch> SetProdSearchList(List<Producto> prodListBinded)
        {
            var localList = new List<InventarioDtos.ProdListSearch>();
            for (int i = 0; i < prodListBinded.Count; i++)
            {
                localList.Add(new InventarioDtos.ProdListSearch
                {
                    Id = i + 1,
                    Codigo = prodListBinded[i].Codigo,
                    Descripcion = prodListBinded[i].Descripcion,
                    Precio = prodListBinded[i].PrecioVenta
                });
            }
            return localList;
        }

        public List<InventarioDtos.ProdListSearch> GetProductoSearch()
        {
            var query = from p in dbCtx.Productos
                        select new InventarioDtos.ProdListSearch
                        {
                            Codigo = p.Codigo,
                            Descripcion = p.Descripcion,
                            Id = p.IdProducto,
                            Precio = p.PrecioVenta
                        };
            return query.ToList();
        }

        public List<InventarioDtos.ExistenciasCantidad> GetProductoExistenciasList(int prodId)
        {
            var productosQuery = from e in dbCtx.Existencias
                                 where e.IdProducto == prodId
                                 select new InventarioDtos.ExistenciasCantidad
                                 {
                                     CantidadTotal = e.Cantidad
                                 };
            return productosQuery.ToList();
        }

        public InventarioDtos.ExistenciasCantidad GetProductoExistencias(int idProducto)
        {
            var productosQuery = from e in dbCtx.Existencias
                                 where e.IdProducto == idProducto
                                 select new InventarioDtos.ExistenciasCantidad
                                 {
                                     CantidadTotal = e.Cantidad
                                 };
            return productosQuery.FirstOrDefault();
        }

        public Producto GetProductoByCode(string code)
        {
            var query = (from p in dbCtx.Productos
                         where p.Codigo == code
                         select p).FirstOrDefault();
            return query;
        }

        public Producto GetProductoById(int idProducto)
        {
            var query = (from p in dbCtx.Productos
                         where p.IdProducto == idProducto
                         select p).FirstOrDefault();
            return query;
        }

        public Existencia GetExistenciaByIdProducto(int idProducto)
        {
            var query = (from e in dbCtx.Existencias
                         where e.IdProducto == idProducto
                         select e).FirstOrDefault();
            return query;
        }
        #endregion

        #region existencias
        public int UpdateExistencia(Existencia exist, decimal cantidad)
        {
            exist.Cantidad += cantidad;
            return dbCtx.SaveChanges();
        }

        public int InsertExistencia(int idProd, decimal cantidad)
        {
            var newExis = new Existencia
            {
                Cantidad = cantidad,
                IdProducto = idProd
            };
            dbCtx.Existencias.Add(newExis);
            return dbCtx.SaveChanges();
        }
        #endregion                
        
    }
}
