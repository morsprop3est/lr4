using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class SensorRepository : BaseRepository<Data>, ISensorRepository
    {
        internal SensorRepository(DataContext context) : base(context)
        {
        }
    }
}