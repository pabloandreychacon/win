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
    public class GeneralR : ControlBase
    {
        // ctors
        public GeneralR()
        {
        }

        public GeneralR(ControlEntities passedCtx)
            : base
            (passedCtx)
        {
        }

        public IEnumerable<Usuario> GetUsuario(string name, string pass)
        {
            return dbCtx.Usuarios.Where(u => u.Nombre == name && u.Clave == pass).Take(1).ToList();
        }

        public IEnumerable<Usuario> GetUsuarioById(int id)
        {
            return dbCtx.Usuarios.Where(u => u.IdUsuario == id).Take(1).ToList();
        }

        #region general
        public ParametrosGeneral GetGenParams()
        {
            return dbCtx.ParametrosGenerals.FirstOrDefault();
        }

        public string GetRedondeo()
        {
            var queryJoin = from pg in dbCtx.ParametrosGenerals
                            select pg.Redondeo;
            return queryJoin.ToString();
        }

        public void SaveBitacora(string descripcion, bool isError, int userId)
        {
            var NewBitacoraRecord = new Bitacora
            {
                IdUsuario = userId,
                Descripcion = descripcion,
                Fecha = DateTime.Now,
                Error = isError
            };
            try
            {
                dbCtx.Bitacoras.Add(NewBitacoraRecord);
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(NewBitacoraRecord);
                throw;
            }
        }

        #endregion
    }
}
