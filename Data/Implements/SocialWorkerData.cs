using Data.Interfaces;
using Entity.Context;
using Entity.Model;

namespace Data.Implements
{
    public class SocialWorkerData : BaseData.BaseModelData<SocialWorker>, ISocialWorkerData
    {
        public SocialWorkerData(ApplicationDbContext context) : base(context)
        {
        }
    }
}
