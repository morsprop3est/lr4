using DAL.EF;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class WaterQualityStandartRepository : BaseRepository<WaterQualityStandard>, IWaterQualityStandartRepository
    {
        internal WaterQualityStandartRepository(SamplingContext context) : base(context)
        {
        }
    }
}