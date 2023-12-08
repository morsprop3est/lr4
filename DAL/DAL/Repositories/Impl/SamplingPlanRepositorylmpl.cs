using DAL.DAL.EF;
using DAL.DAL.Entities;
using DAL.DAL.Repositories.Interfaces;
using DAL.Repositories.Interfaces;
using lr4.Repositories.Impl;

namespace DAL.DAL.Repositories.Impl
{
    public class SamplingPlanRepository : BaseRepository<SamplingPlan>, ISamplingPlanRepository
    {
        internal SamplingPlanRepository(SamplingContext context) : base(context)
        {
        }
    }
}