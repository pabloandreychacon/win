using ControlEntity.DataTransferObjects;
using ControlData.Repository;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

// aqui sucede el enlace entre la interface y el repo con todos los metodos implementados
// layers example on http://www.asp.net/web-forms/tutorials/continuing-with-ef/using-the-entity-framework-and-the-objectdatasource-control-part-2-adding-a-business-logic-layer-and-unit-tests
// la idea es usar esta clase en la capa de presentacion en lugar de usar el model context del EF directamente
// ademas de permitir el uso de UnitTest

// deberia haber uno por cada entity: productos, existencias, proveedores, etc
namespace ControlBusiness.Business
{
    //public class InventarioB : InventarioR // hay que agregar ControlData project a la presentation
    public class InventarioB
    {
        //private IInventario inventarioR; // requiere using ControlData.Repository;
        private InventarioR inventarioR; // requiere using ControlData.Repository;

        public InventarioB()
        {
            // este constructor enlaza con el repositorio elegido + usado
            inventarioR = new InventarioR();
        }

        public InventarioB(InventarioR inventRepo)
        {
            // este constructor enlza con el repositorio que se pasa como parametro
            // para usar con testing project or ninject
            inventarioR = inventRepo;
        }

        // methods
        #region producto
        public List<InventarioDtos.ProdListSearch> SetProdSearchList(List<Producto> prodListBinded)
        {
            return inventarioR.SetProdSearchList(prodListBinded);
        }

        public List<InventarioDtos.ProdListSearch> GetProductoSearch()
        {
            return inventarioR.GetProductoSearch();
        }

        public List<InventarioDtos.ExistenciasCantidad> GetProductoExistenciasList(int prodId)
        {
            return inventarioR.GetProductoExistenciasList(prodId);
        }

        public InventarioDtos.ExistenciasCantidad GetProductoExistencias(int idProducto)
        {
            return inventarioR.GetProductoExistencias(idProducto);
        }
        
        public Producto GetProductoByCode(string code)
        {
            return inventarioR.GetProductoByCode(code);
        }

        public Producto GetProductoById(int idProducto)
        {
            return inventarioR.GetProductoById(idProducto);
        }

        public Existencia GetExistenciaByIdProducto(int idProducto)
        {
            return inventarioR.GetExistenciaByIdProducto(idProducto);
        }  
        #endregion

        #region existencias
        public int UpdateExistencia(Existencia exist, decimal cantidad)
        {
            return inventarioR.UpdateExistencia(exist, cantidad);
        }

        public int InsertExistencia(int idProd, decimal cantidad)
        {
            return inventarioR.InsertExistencia(idProd, cantidad);
        }
        #endregion

    }
}
