using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class StatisticsRepository : BaseRepository<Data>, IStatisticsRepository
    {
        internal StatisticsRepository(DataContext context) : base(context)
        {
        }
    }
}