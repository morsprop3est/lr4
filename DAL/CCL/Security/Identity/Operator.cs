using OSBB.Security.Identity;

namespace DAL.CCL.Security.Identity
{
    public class Operator
        : User
    {
        public Operator(int userId, string name) 
            : base(userId, name, nameof(Operator))
        {
        }
    }
}