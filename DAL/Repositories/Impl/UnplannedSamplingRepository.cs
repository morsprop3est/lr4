using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class UnplannedSamplingRepository : BaseRepository<Data>, IUnplannedSamplingRepository
    {
        internal UnplannedSamplingRepository(DataContext context) : base(context)
        {
        }
    }
}