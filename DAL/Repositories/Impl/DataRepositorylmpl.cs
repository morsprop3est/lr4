using DAL.EF;
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