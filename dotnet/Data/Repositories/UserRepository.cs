using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository(MainContext context) : base(context)
        {
        }
    }
}
