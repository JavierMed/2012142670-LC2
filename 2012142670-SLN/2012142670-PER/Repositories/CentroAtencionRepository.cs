using _2012142670_ENT.Entities;
using _2012142670_ENT.IRepositories;

namespace _2012142670_PER.Repositories
{
    public class CentroAtencionRepository : Repository<CentroAtencion>, ICentroAtencion
    {
        public CentroAtencionRepository(_2012142670DBContext context):base(context)
        {

        }
    }
}
