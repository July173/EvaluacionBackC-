using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class ChildData : BaseData.BaseModelData<Child>, IChildData
    {
        public ChildData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
