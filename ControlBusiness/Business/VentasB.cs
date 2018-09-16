using ControlEntity.DataTransferObjects;
using ControlData.Repository;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlBusiness.Business
{
    //public class VentasB : VentasR
    public class VentasB
    {
        private VentasR ventasR;
        public VentasB()
        {
            ventasR = new VentasR();
        }

        public VentasB(VentasR ventasRepo)
        {
            ventasR = ventasRepo;
        }

        // methods      
        #region ventas y detalle ventas
        public int GetVentaByConsecutivo(int consecutivo)
        {
            return ventasR.GetVentaByConsecutivo(consecutivo);
        }

        public List<VentasDtos.VentasQuery> ConsultaVentas()
        {
            return ventasR.ConsultaVentas();
        }

        public Venta ConsultaEncabezado(int idVenta)
        {
            return ventasR.ConsultaEncabezado(idVenta);
        }

        public List<VentasDtos.VentasComprobanteDetalle> ConsultaDetalle(int consecutivo)
        {
            return ventasR.ConsultaDetalle(consecutivo);
        }        
        #endregion

        #region cajas    
        public Caja GetCajaById(int idCaja)
        {
            return ventasR.GetCajaById(idCaja);
        }

        public int UpdateStatusCaja(bool ocupada, int idCaja)
        {
            return ventasR.UpdateStatusCaja(ocupada, idCaja);
        }

        public int GetIdCajaByUser(int idUser)
        {
            return ventasR.GetIdCajaByUser(idUser);
        }

        public bool UsaConsecutivoGlobal(int idCaja)
        {
            return ventasR.UsaConsecutivoGlobal(idCaja);
        }        
        #endregion

        public ParametrosVenta GetVentasParams()
        {
            return ventasR.GetEntity<ParametrosVenta>();
        }

        public int UpdateConsecutivoGlobal()
        {
            return ventasR.UpdateConsecutivoGlobal();
        }

        public int UpdateSaldoCaja(int idCaja, decimal montoEfectivo,
            decimal montoDocumentos)
        {
            return  ventasR.UpdateSaldoCaja(idCaja, montoEfectivo, montoDocumentos);
        }

        public void InsertPagoCaja(string formaPago, int idCaja)
        {
            ventasR.InsertPagoCaja(formaPago, idCaja);
        }

        public void DeleteFormaPago(string formaPago, int idCaja)
        {
            ventasR.DeleteFormaPago(formaPago, idCaja);
        }

        public void SavePago(Pago pago)
        {
            ventasR.SavePago(pago);
        }

        public List<string> GetFormasPagoByIdCaja(int idCaja)
        {
            return ventasR.GetFormasPagoByIdCaja(idCaja);
        }

        public List<PagosCaja> GetPagosCajaByIdCaja(int idCaja)
        {
            return ventasR.GetPagosCajaByIdCaja(idCaja);
        }

        public Type GetCajaTypeForBinding()
        {
            return ventasR.GetCajaTypeForBinding();
        }
    }
}
