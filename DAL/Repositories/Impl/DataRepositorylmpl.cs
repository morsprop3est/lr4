using lr4.DAL.Repositories.Interfaces;

namespace lr4.Repositories.Impl
{
    public class DataRepository : BaseRepository<Data>, IDataRepository
    {
        internal DataRepository(DataContext context) : base(context)
        {
        }
    }
}