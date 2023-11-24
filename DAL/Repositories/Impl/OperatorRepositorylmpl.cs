using lab4.EF;
using lab4.Entities;
using lab4.Repositories.Interfaces;

namespace lab4.Repositories.Impl
{
    public class OperatorRepository : BaseRepository<Data>, IOperatorRepository
    {
        internal OperatorRepository(DataContext context) : base(context)
        {
        }
    }
}