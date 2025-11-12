using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class AdoptionDetailData : BaseData.BaseModelData<AdoptionDetail>, IAdoptionDetailData
    {
        public AdoptionDetailData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
