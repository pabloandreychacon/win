using ControlEntity;

namespace ControlData.DataRepository.Context
{
    public class ControlContext
    {
        // se hace global para que todos usen el mismo
        private static readonly ControlEntities dbCtx = new ControlEntities();
        public static ControlEntities DbCtx
        {
            get { return dbCtx; }
        }
    }
}
