using DAL.DAL.Repositories.Interfaces;
using DAL.Repositories.Interfaces;
using OSBB.Security.Identity;

namespace DAL.CCL.Security
{
    public interface IUserRepository
        : IRepository<User>
    {
    }
}