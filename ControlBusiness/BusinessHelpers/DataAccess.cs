using ControlBusiness.BusinessEntities;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ControlBusiness.BusinessHelpers
{
    public static class DataAccess
    {
        /// dbcontext
        public static ControlEntities localCtx = ControlData.DataRepository.Context.ControlContext.DbCtx;// = new ControlEntities();

        #region no table especific

        /// lo mas veloz para ejecutar commandos contra la db
        public static int ExecuteSql(string sql)
        {
            var affected = localCtx.Database.ExecuteSqlCommand(sql);
            return affected;
        }

        public static decimal GetSaldoCliente(int idCLiente)
        {
            var sql = "Select isnull(dbo.GetSaldoActualByCliente(" + idCLiente.ToString() + "),0)";
            var saldo = localCtx.Database.SqlQuery<decimal>(sql).FirstOrDefault();
            return saldo;
        }

        // Detallefactura
        public static List<DetalleLine> ConsultaCart(DetalleFactura sale, int idUser)
        {
            var queryJoin = sale.CartLines;
            return queryJoin.ToList();
        }
        
        #endregion     

    }
}
