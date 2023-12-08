using DAL.DAL.EF;
using DAL.DAL.Repositories.Impl;
using lr4.Repositories.Impl;
using OSBB.Security.Identity;

namespace DAL.CCL.Security
{
    public class UserRepository
        : BaseRepository<User>
    {
        public UserRepository(SamplingContext context) : base(context)
        {
        }
    }
}