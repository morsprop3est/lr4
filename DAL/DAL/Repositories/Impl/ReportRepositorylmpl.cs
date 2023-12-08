using DAL.EF;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        internal ReportRepository(SamplingContext context) : base(context)
        {
        }
    }
}