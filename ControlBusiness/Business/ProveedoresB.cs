using ControlEntity.DataTransferObjects;
using ControlData.Repository;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlBusiness.Business
{
    public class ProveedoresB
    {
        private ProveedoresR proveedoresR;

        public ProveedoresB()
        {
            proveedoresR = new ProveedoresR();
        }

        public ProveedoresB(ProveedoresR inventRepo)
        {
            proveedoresR = inventRepo;
        }

        // methods
        #region non-repo methods proveedores
        public List<ProveeduriaDtos.ProvListSearch> SetProvSearchList(List<Proveedore> provListBinded)
        {
            return proveedoresR.SetProvSearchList(provListBinded);
        }

        public List<Proveedore> GetProvSearchList(List<Proveedore> provListBinded)
        {
            return proveedoresR.GetProvSearchList(provListBinded);
        }

        public List<Proveedore> SetProvSearchList()
        {
            return proveedoresR.SetProvSearchList();
        }

        public List<ProveeduriaDtos.ProveedorProductos> GetProveedorProductos(int provId)
        {
            return proveedoresR.GetProveedorProductos(provId);
        }
        #endregion

    }
}
