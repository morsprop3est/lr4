using DAL.EF;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class StatisticsRepository : BaseRepository<Statistics>, IStatisticsRepository
    {
        internal StatisticsRepository(SamplingContext context) : base(context)
        {
        }
    }
}