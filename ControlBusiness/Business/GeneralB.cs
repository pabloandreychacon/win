using ControlData.Repository;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlBusiness.Business
{
    public class GeneralB
    {
        private GeneralR generalR;
        public GeneralB()
        {
            generalR = new GeneralR();
        }

        public GeneralB(GeneralR controlRepository)
        {
            generalR = controlRepository;
        }
        
        public void BeginTran()
        {
            generalR.BeginTran();
        }

        public void Commit()
        {
            generalR.Commit();
        }

        public void Rollback()
        {
            generalR.Rollback();
        }

        #region usuarios
        public IEnumerable<Usuario> GetUsuario(string name, string pass)
        {
            return generalR.GetUsuario(name, pass);
        }

        public IEnumerable<Usuario> GetUsuarioById(int id)
        {
            return generalR.GetUsuarioById(id);
        }
        #endregion

        #region general
        /// <summary>
        /// parametros gen
        /// </summary>
        /// <returns></returns>
        public ParametrosGeneral GetGenParams()
        {
            return generalR.GetGenParams();
        }
        public string GetRedondeo()
        {
            return generalR.GetRedondeo();
        }
        
        /// metodos para usar table bitacora
        public void SaveBitacora(string descripcion, bool isError, int userId)
        {
            generalR.SaveBitacora(descripcion, isError, userId);
        }

        #endregion
    }
}
