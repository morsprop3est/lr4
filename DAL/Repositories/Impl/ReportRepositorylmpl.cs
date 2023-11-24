using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class ReportRepository : BaseRepository<Data>, IReportRepository
    {
        internal ReportRepository(DataContext context) : base(context)
        {
        }
    }
}