using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class ChildOrphanageData : BaseData.BaseModelData<ChildOrphanage>, IChildOrphanageData
    {
        public ChildOrphanageData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
