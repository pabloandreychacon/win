using ControlData.DataRepository.Context;
using ControlEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ControlData.DataRepository.Abstract
{
    public abstract class ControlBase
    {
        // fields
        private DbContextTransaction dbCtxTran;

        // props
        public ControlEntities dbCtx { get; set; }
        private string myPropertyExample = "";
        public string MyPropertyExample 
        {
            get { return myPropertyExample; } // read only
            //set { myPropertyExample = value; }
        }
        public string MyAutoPropertyExample { get; set; }

        // ctors
        public ControlBase()
        {
            if (dbCtx == null)
                dbCtx = ControlContext.DbCtx;
        }
        
        public ControlBase(ControlEntities db)
        {
            dbCtx = db; // por si quiero usar otro contextDb que no sea el static ControlContext.DbCtx 
        }

        // general methods non virtual
        public void BeginTran()
        {
            dbCtxTran = dbCtx.Database.BeginTransaction();
        }

        public void Commit()
        {
            dbCtxTran.Commit();
        }

        public void Rollback()
        {
            dbCtxTran.Rollback();
        }

        public void AddEntity<E>(E entity) where E : class
        {
            dbCtx.Set<E>().Add(entity);
        }

        public void CreateEntity<E>(E entity) where E : class
        {
            dbCtx.Set<E>().Add(entity);
            dbCtx.SaveChanges();
        }

        public void UpdateEntity<E>(E entity) where E : class
        {
            try
            {
                if (dbCtx.Entry(entity).State == EntityState.Unchanged) return;
                dbCtx.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                ReloadEntity(entity);
                throw;
            }
        }

        public void DeleteEntity<E>(E entity) where E : class
        {
            dbCtx.Set<E>().Remove(entity);
            dbCtx.SaveChanges();
        }

        public void ReloadEntity<T>(T entity) where T : class
        {
            dbCtx.Entry(entity).Reload();
        }

        public E SetEntity<E>(object obj) where E : class
        {
            return (E)obj;
        }

        public E GetEntity<E>() where E : class
        {
            return dbCtx.Set<E>().FirstOrDefault();
        }

        public IEnumerable<E> GetList<E>() where E : class
        {
            IEnumerable<E> result = dbCtx.Set<E>();
            return result.ToList();
        }

        public BindingList<E> GetBindList<E>() where E : class
        {
            dbCtx.Set<E>().Load();
            var bindList = dbCtx.Set<E>().Local.ToBindingList();
            return bindList;
        }

        // virtual methods for overriding
        public virtual string SayName()
        {
            return MyAutoPropertyExample + MyPropertyExample + " Inside ControlR.SayName()";
        }   

    }
}
