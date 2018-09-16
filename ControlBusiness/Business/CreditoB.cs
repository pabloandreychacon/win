using ControlEntity.DataTransferObjects;
using ControlData.Repository;
using ControlEntity;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlBusiness.Business
{
    public class CreditoB
    {
        private CreditoR creditoR;

        public CreditoB()
        {
            creditoR = new CreditoR();
        }

        public CreditoB(CreditoR controlRepository)
        {
            creditoR = controlRepository;
        }

        // methods
        public void BeginTran()
        {
            creditoR.BeginTran();
        }

        public void Commit()
        {
            creditoR.Commit();
        }

        public void Rollback()
        {
            creditoR.Rollback();
        }

        #region credito
        public Cliente GetClienteById(int idCliente)
        {
            return creditoR.GetClienteById(idCliente);
        }

        public Cliente GetClienteContado()
        {
            return creditoR.GetClienteContado();
        }

        public List<CreditoDtos.ClienteListSearch> GetClientesSearch()
        {
            return creditoR.GetClientesSearch();
        }

        public List<CreditoDtos.ClienteListSearch> SetClienteSearchList(List<Cliente> clientList)
        {
            return creditoR.SetClienteSearchList(clientList);
        }

        public FrecuenciasPago GetFrecuenciaById(int frecu)
        {
            return creditoR.GetFrecuenciaById(frecu);
        }

        public BindingList<LineasCredito> GetBindLineas()
        {
            return creditoR.GetBindLineas();
        }

        public LineasCredito SetLinea(object linea)
        {
            return creditoR.SetLinea(linea);
        }

        public void UpdateLinea(LineasCredito linea)
        {
            creditoR.UpdateLinea(linea);
        }

        public List<LineasCredito> GetLineas()
        {
            return creditoR.GetLineas();
        }

        public LineasCredito GetLineaById(int line)
        {
            return creditoR.GetLineaById(line);
        }

        public int UpdateConsecutivoLineaById(int line)
        {
            return creditoR.UpdateConsecutivoLineaById(line);
        }

        public Credito GetNewCredito()
        {
            return creditoR.GetNewCredito();
        }

        public int SaveNewCredito(Credito newCredit)
        {
            return creditoR.SaveNewCredito(newCredit);
        }
        #endregion

    }
}
