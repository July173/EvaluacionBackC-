using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class ParentData : BaseData.BaseModelData<Parent>, IParentData
    {
        public ParentData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
