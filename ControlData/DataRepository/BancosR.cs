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
    public class BancosR : ControlBase
    {
        // ctors
        public BancosR()
        {
        }

        public BancosR(ControlEntities passedCtx)
            : base
            (passedCtx)
        {
        }

        // methods: generic intefaced
        // methods to override
        // methods interfaced
        #region bancos methods        
        public Type GetTarjetaTypeForBinding()
        {
            var tarj = typeof(Tarjeta);
            return tarj;
        }
        public Type GetBancoTypeForBinding()
        {
            var bank = typeof(Banco);
            return bank;
        }
        #endregion
    }
}
