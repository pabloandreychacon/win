using ControlData.DataRepository.Abstract;
using ControlEntity.DataTransferObjects;
using ControlEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ControlData.Repository
{
    public class ProveedoresR : ControlBase
    {
        // ctors
        public ProveedoresR()
        {
        }

        public ProveedoresR(ControlEntities passedCtx)
            : base
            (passedCtx)
        {
        }
        
        #region non-repo methods proveedores
        public List<ProveeduriaDtos.ProvListSearch> SetProvSearchList(List<Proveedore> provListBinded)
        {
            var localList = new List<ProveeduriaDtos.ProvListSearch>();
            for (int i = 0; i < provListBinded.Count; i++)
            {
                localList.Add(new ProveeduriaDtos.ProvListSearch
                {
                    Pos = i + 1,
                    Descripcion = provListBinded[i].Descripcion
                });
            }
            return localList;
        }

        public List<Proveedore> GetProvSearchList(List<Proveedore> provListBinded)
        {
            var localList = new List<Proveedore>();
            for (int i = 0; i < provListBinded.Count; i++)
            {
                localList.Add(new Proveedore
                {
                    IdProveedor = i + 1,
                    Descripcion = provListBinded[i].Descripcion
                });
            }
            return localList;
        }

        public List<Proveedore> SetProvSearchList()
        {
            //var db = proveedoresR.db;
            var query = from p in dbCtx.Proveedores
                        select new { Descripcion = p.Descripcion };
            var proveedores = query.ToList().
                Select(prov => new Proveedore { Descripcion = prov.Descripcion }).
                ToList();
            return proveedores;
        }

        public List<ProveeduriaDtos.ProveedorProductos> GetProveedorProductos(int provId)
        {
            //var db = proveedoresR.db;
            var proveedoresQuery = from e in dbCtx.Productos
                                   where e.IdProveedor == provId
                                   select new ProveeduriaDtos.ProveedorProductos
                                   {
                                       IdProducto = e.IdProducto,
                                       Codigo = e.Codigo,
                                       Descripcion = e.Descripcion
                                   };
            return proveedoresQuery.ToList();
        }
        #endregion
        
    } 
}
