using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class OrphanageData : BaseData.BaseModelData<Orphanage>, IOrphanageData
    {
        public OrphanageData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
