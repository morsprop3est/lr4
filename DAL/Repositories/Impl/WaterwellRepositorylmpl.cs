using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class WaterwellRepository : BaseRepository<Data>, IWaterwellRepository
    {
        internal WaterwellRepository(DataContext context) : base(context)
        {
        }
    }
}