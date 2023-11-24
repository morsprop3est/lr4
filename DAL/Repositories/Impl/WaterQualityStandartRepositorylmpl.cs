using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class WaterQualityStandartRepository : BaseRepository<Data>, IWaterQualityStandartRepository
    {
        internal WaterQualityStandartRepository(DataContext context) : base(context)
        {
        }
    }
}