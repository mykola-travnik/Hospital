using Data.Repositories;

namespace Business.DataSeedService
{
    public class RoleDataSeedService : IRoleDataSeedService
    {
        private readonly IRoleRepository repository;

        public static Role AdminRole = new Role()
        {
            Id = Guid.Parse("261DD46F-3A29-49F3-9D9B-3A577CC85759"),
            Name = "Admin",
            Description = "Администратор системы",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public static Role UserRole = new Role()
        {
            Id = Guid.Parse("07B221A0-A9DE-43EA-9781-7FBED7512BDB"),
            Name = "User",
            Description = "Пользователь системы",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public RoleDataSeedService(IRoleRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            await repository.CreateOrUpdateRangeAsync(new List<Role> { AdminRole, UserRole });
        }
    }
}