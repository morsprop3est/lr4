using DAL.DAL.EF;
using DAL.DAL.Entities;
using DAL.DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class SensorRepository : BaseRepository<Sensor>, ISensorRepository
    {
        internal SensorRepository(SamplingContext context) : base(context)
        {
        }
    }
}