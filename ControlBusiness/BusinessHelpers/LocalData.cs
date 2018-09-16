using ControlBusiness.Business;
using ControlEntity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlBusiness.BusinessHelpers
{
    public static class LocalData
    {
        public static List<InventarioDtos.ProdListSearch> prodSearchList;
        public static List<CreditoDtos.ClienteListSearch> searchClientesList;
        public static List<ProveeduriaDtos.ProvListSearch> searchProvList;

        static VentasB ventB = new VentasB();
        
        public static List<GeneralDtos.RedondeoList> GetRedondeoList()
        {
            Type redondeos = typeof(BaseHelpers.Helpers.Tools.Redondeo.RedondeoTypes);
            var localList = new List<GeneralDtos.RedondeoList>();
            for (int i = 0; i < Enum.GetNames(redondeos).Count(); i++)
            {
                localList.Add(new GeneralDtos.RedondeoList
                {
                    Redondeo = Enum.GetNames(redondeos)[i]
                });
            }
            return localList;

        }
        
        public static VentasDtos.PagosCaja GetNewPagosCaja()
        {
            return new VentasDtos.PagosCaja();
        }

        public static List<VentasDtos.PagosCaja> GetFormasPagoDisponibles(int idCaja)
        {
            var formasPagoSelected = ventB.GetFormasPagoByIdCaja(idCaja);
            var formasPagoTodas = GetFormasPago();
            var formasPagoDispo = from fp in formasPagoTodas
                                  where !(formasPagoSelected.Contains(fp.FormaPago))
                                  select new VentasDtos.PagosCaja
                                  {
                                      FormaPago = fp.FormaPago
                                  };
            return formasPagoDispo.ToList();
        }

        public static List<VentasDtos.PagosCaja> GetPagosCaja(int idCaja)
        {
            var query = ventB.GetPagosCajaByIdCaja(idCaja);
            var list = new List<VentasDtos.PagosCaja>();
            foreach (var s in query)
            {
                list.Add(new VentasDtos.PagosCaja
                {
                    FormaPago = s.FormaPago,
                });
            }
            return list;
        }

        public static List<VentasDtos.PagosCaja> GetFormasPago()
        {
            var list = new List<VentasDtos.PagosCaja>();
            Type formasPago = typeof(BaseHelpers.Helpers.Tools.FormasPagoEnum.FormasPagoTypes);
            var listP = Enum.GetNames(formasPago);
            foreach (string s in listP)
            {
                list.Add(new VentasDtos.PagosCaja
                {
                    FormaPago = s
                });
            }
            return list;
        }
               
    }
}
