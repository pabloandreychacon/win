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
    public class VentasR : ControlBase
    {
        // ctors
        public VentasR()
        {
        }

        public VentasR(ControlEntities passedCtx)
            : base
            (passedCtx)
        {
        }

        #region non-repo methods ventas
        public Caja GetCajaById(int idCaja)
        {
            Caja caj = dbCtx.Cajas.FirstOrDefault(c => c.IdCaja == idCaja);
            return caj;
        }

        public int GetVentaByConsecutivo(int consecutivo)
        {
            var queryJoin = (from v in dbCtx.Ventas
                             where v.Consecutivo == consecutivo
                             select v.IdVenta).FirstOrDefault();
            return queryJoin;
        }

        public List<VentasDtos.VentasQuery> ConsultaVentas()
        {
            var query = from u in dbCtx.Usuarios
                        from v in dbCtx.Ventas
                        from d in dbCtx.DetalleVentas
                        where u.IdUsuario == v.IdUsuario &&
                            v.IdVenta == d.IdVenta
                        select new VentasDtos.VentasQuery
                        {
                            Consecutivo = v.Consecutivo,
                            Fecha = v.Fecha,
                            Caja = v.IdCaja,
                            Cajero = u.Nombre,
                            Total = 0
                        };
            return query.ToList();
        }

        public Venta ConsultaEncabezado(int idVenta)
        {
            var queryJoin = from d in dbCtx.Ventas
                            where d.IdVenta == idVenta
                            select d;
            return queryJoin.FirstOrDefault();
        }

        public List<VentasDtos.VentasComprobanteDetalle> ConsultaDetalle(int consecutivo)
        {
            var queryJoin = from d in dbCtx.DetalleVentas
                            join p in dbCtx.Productos on d.IdProducto equals p.IdProducto
                            where d.IdVenta == consecutivo
                            select new VentasDtos.VentasComprobanteDetalle
                            {
                                Descripcion = p.Descripcion,
                                Cantidad = d.Cantidad,
                                Precio = d.Precio,
                                TotalLinea = d.TotalLinea,
                                Descuento = d.Descuento,
                                Impuesto = d.Impuestos
                            };
            return queryJoin.ToList();
        }

        public int UpdateStatusCaja(bool ocupada, int idCaja)
        {
            Caja caj = (from c in dbCtx.Cajas
                        where c.IdCaja == idCaja
                        select c).First();
            caj.Disponible = ocupada;
            var affected = dbCtx.SaveChanges();
            return affected;
        }

        public int GetIdCajaByUser(int idUser)
        {
            var queryJoin = from c in dbCtx.Cajas
                            where c.IdUsuario == idUser && c.Disponible
                            select c.IdCaja;
            return queryJoin.FirstOrDefault();
        }

        public bool UsaConsecutivoGlobal(int idCaja)
        {
            var queryJoin = from c in dbCtx.Cajas
                            where c.IdCaja == idCaja
                            select c.UsaConsecutivoGlobal;
            return queryJoin.FirstOrDefault();
        }

        public int UpdateConsecutivoGlobal()
        {
            ParametrosVenta par = GetEntity<ParametrosVenta>();
            par.ConsecutivoGlobalFacturas += 1;
            return dbCtx.SaveChanges();
        }

        public int UpdateSaldoCaja(int idCaja, decimal montoEfectivo,
            decimal montoDocumentos)
        {
            var saldocaja = (from sc in dbCtx.SaldoCajas
                             where sc.IdCaja == idCaja
                             select sc).FirstOrDefault();
            try
            {
                if (saldocaja != null)
                {
                    saldocaja.SaldoEfectivo += montoEfectivo;
                    saldocaja.SaldoDocumentos += montoDocumentos;
                    dbCtx.Entry(saldocaja).State = saldocaja.IdSaldoCaja == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified;
                    return dbCtx.SaveChanges();
                }
                else
                {
                    var newSaldoCaja = new SaldoCaja
                    {
                        IdCaja = idCaja,
                        MontoInicial = 0,
                        SaldoEfectivo = montoEfectivo,
                        SaldoDocumentos = montoDocumentos
                    };
                    dbCtx.SaldoCajas.Add(newSaldoCaja);
                    return dbCtx.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(saldocaja);
                throw;
            }
        }

        public void InsertPagoCaja(string formaPago, int idCaja)
        {
            var NewPagoCaja = new PagosCaja
            {
                FormaPago = formaPago,
                IdCaja = idCaja
            };
            try
            {
                dbCtx.PagosCajas.Add(NewPagoCaja);
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(NewPagoCaja);
                throw;
            }
        }

        public List<string> GetFormasPagoByIdCaja(int idCaja)
        {
            var query = from pc in dbCtx.PagosCajas
                        where pc.IdCaja == idCaja
                        select pc.FormaPago;
            return query.ToList();
        }

        public void DeleteFormaPago(string formaPago, int idCaja)
        {
            var query = (from fp in dbCtx.PagosCajas
                         where fp.IdCaja == idCaja && fp.FormaPago == formaPago
                         select fp).Single();
            try
            {
                dbCtx.PagosCajas.Remove(query);
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(query);
                throw;
            }
        }

        public void SavePago(Pago pago)
        {
            try
            {
                dbCtx.Pagos.Add(pago);
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(pago);
                throw;
            }
        }  

        public List<PagosCaja> GetPagosCajaByIdCaja(int idCaja)
        {
            var query = (from pc in dbCtx.PagosCajas
                         where pc.IdCaja == idCaja
                         select pc).ToList();
            return query;
        }

        public Type GetCajaTypeForBinding()
        {
            var type = typeof(Caja);
            return type;
        }
        #endregion
    }
}
