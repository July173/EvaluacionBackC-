using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class AdoptionData : BaseData.BaseModelData<Adoption>, IAdoptionData
    {
        public AdoptionData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
