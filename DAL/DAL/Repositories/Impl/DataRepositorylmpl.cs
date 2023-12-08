using DAL.DAL.EF;
using DAL.DAL.Entities;
using DAL.DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class DataRepository : BaseRepository<Data>, IDataRepository
    {
        internal DataRepository(SamplingContext context) : base(context)
        {
        }
    }
}