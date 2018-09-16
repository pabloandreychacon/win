using ControlEntity.DataTransferObjects;
using ControlData.DataRepository.Abstract;
using ControlEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ControlData.Repository
{
    public class CreditoR : ControlBase
    {
        // ctors
        public CreditoR()
        {
        }

        public CreditoR(ControlEntities passedCtx)
            : base
            (passedCtx)
        {
        }

        // methods: generic intefaced

        // methods to override

        // methods interfaced
        #region credito

        public Cliente GetClienteById(int idCliente)
        {
            return dbCtx.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);
        }

        public Cliente GetClienteContado()
        {
            return dbCtx.Clientes.FirstOrDefault(c => c.Contado == true);
        }

        public List<CreditoDtos.ClienteListSearch> GetClientesSearch()
        {
            var query = from c in dbCtx.Clientes
                        select new CreditoDtos.ClienteListSearch
                        {
                            Id = c.IdCliente,
                            Nombre = c.Nombre
                        };
            return query.ToList();
        }

        public List<CreditoDtos.ClienteListSearch> SetClienteSearchList(List<Cliente> clientList)
        {
            var localList = new List<CreditoDtos.ClienteListSearch>();
            for (int i = 0; i < clientList.Count; i++)
            {
                localList.Add(new CreditoDtos.ClienteListSearch
                {
                    Id = i + 1,
                    Nombre = clientList[i].Nombre
                });
            }
            return localList;
        }

        public FrecuenciasPago GetFrecuenciaById(int frecu)
        {
            var query = (from l in dbCtx.FrecuenciasPagoes
                         where l.IdFrecuenciaPago == frecu
                         select l).FirstOrDefault();
            return query;
        }

        public BindingList<LineasCredito> GetBindLineas()
        {
            dbCtx.LineasCreditoes.OrderBy(c => c.IdLineaCredito).Load();
            var linesList = dbCtx.LineasCreditoes.Local.ToBindingList();
            return linesList;
        }

        public LineasCredito SetLinea(object linea)
        {
            return (LineasCredito)linea;
        }

        public void UpdateLinea(LineasCredito linea)
        {
            try
            {
                dbCtx.Entry(linea).State = linea.IdLineaCredito == 0 ?
                               EntityState.Added :
                               EntityState.Modified;
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(linea);
                throw;
            }
        }

        public List<LineasCredito> GetLineas()
        {
            var query = from l in dbCtx.LineasCreditoes
                        select l;
            return query.ToList();
        }

        public LineasCredito GetLineaById(int line)
        {
            var query = (from l in dbCtx.LineasCreditoes
                         where l.IdLineaCredito == line
                         select l).FirstOrDefault();
            return query;
        }

        public int UpdateConsecutivoLineaById(int line)
        {
            var linea = GetLineaById(line);
            linea.Consecutivo += 1;
            return dbCtx.SaveChanges();
        }

        public Credito GetNewCredito()
        {
            var NewCredit = new Credito() { };
            return NewCredit;
        }

        public int SaveNewCredito(Credito newCredit)
        {
            int saved = 0;
            try
            {
                dbCtx.Creditos.Add(newCredit);
                saved = dbCtx.SaveChanges();
                return saved;
            }
            catch (DbUpdateConcurrencyException)
            {
                saved = 0;
                ReloadEntity(newCredit);
                throw;
            }
        }
        #endregion
    }           
}
