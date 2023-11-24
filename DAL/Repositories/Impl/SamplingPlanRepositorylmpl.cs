using DAL.EF;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class SamplingPlanRepository : BaseRepository<SamplingPlan>, ISamplingPlanRepository
    {
        internal SamplingPlanRepository(SamplingContext context) : base(context)
        {
        }
    }
}