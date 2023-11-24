using DAL.EF;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class UnplannedSamplingRepository : BaseRepository<UnplannedSampling>, IUnplannedSamplingRepository
    {
        internal UnplannedSamplingRepository(SamplingContext context) : base(context)
        {
        }
    }
}