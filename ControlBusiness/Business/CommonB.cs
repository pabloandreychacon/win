using ControlData.DataRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBusiness.Business
{
    public class CommonB
    {
        private CommonR commonR;
        public CommonB()
        {
            commonR = new CommonR();
        }

        public CommonB(CommonR commonRepo)
        {
            commonR = commonRepo;
        }

        public void BeginTran()
        {
            commonR.BeginTran();
        }

        public void Commit()
        {
            commonR.Commit();
        }

        public void Rollback()
        {
            commonR.Rollback();
        }

        public void Reload<E>(E entity) where E : class
        {
            commonR.ReloadEntity(entity);
        }

        public E SetEntity<E>(object obj) where E : class
        {
            return commonR.SetEntity<E>(obj);
        }

        public void AddEntity<E>(E entity) where E : class
        {
            commonR.AddEntity<E>(entity);
        }

        public void CreateEntity<E>(E entity) where E : class
        {
            commonR.CreateEntity<E>(entity);
        }

        public void UpdateEntity<E>(Object objProd) where E : class
        {
            var curProd = commonR.SetEntity<E>(objProd);
            commonR.UpdateEntity(curProd);
        }

        public void DeleteProducto<E>(E entity) where E : class
        {
            commonR.DeleteEntity<E>(entity);
        }

        public IEnumerable<E> GetList<E>() where E : class
        {
            return commonR.GetList<E>();
        }

        public BindingList<E> GetBindList<E>() where E : class
        {
            return commonR.GetBindList<E>();
        }

        

    }
}
