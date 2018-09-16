using ControlData.Repository;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlBusiness.Business
{
    public class BancosB
    {
        private BancosR bancosR;
        public BancosB()
        {
            bancosR = new BancosR();
        }

        public BancosB(BancosR bancosRepo)
        {
            bancosR = bancosRepo;
        }

        public Type GetTarjetaTypeForBinding()
        {
            return bancosR.GetTarjetaTypeForBinding();
        }

        public Type GetBancoTypeForBinding()
        {
            return bancosR.GetBancoTypeForBinding();
        }
    }
}
