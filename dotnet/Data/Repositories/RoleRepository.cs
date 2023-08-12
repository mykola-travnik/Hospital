using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class RoleRepository : AbstractRepository<Role>, IRoleRepository
    {
        public RoleRepository(MainContext context) : base(context)
        {
        }
    }
}
