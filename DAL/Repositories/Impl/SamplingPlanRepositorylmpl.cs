using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class SamplingPlanRepository : BaseRepository<Data>, ISamplingPlanRepository
    {
        internal SamplingPlanRepository(DataContext context) : base(context)
        {
        }
    }
}