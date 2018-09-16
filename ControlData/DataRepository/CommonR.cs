using ControlData.DataRepository.Abstract;
using ControlEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlData.DataRepository
{
    public class CommonR : ControlBase
    {
        // ctors
        public CommonR()
        {
        }

        public CommonR(ControlEntities passedCtx) : base(passedCtx)
        {
        }
    }
}
