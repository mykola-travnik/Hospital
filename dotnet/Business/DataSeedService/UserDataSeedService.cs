using Data.Repositories;
using Domain.Models;

namespace Business.DataSeedService;

public class UserDataSeedService : IUserDataSeedService
{
    public static User User0 = new()
    {
        Id = Guid.Parse("FCD5A2F2-2E48-4620-A843-F8E0D82BC109"),
        Name = "user",
        Password = HashHelpers.GetHashString("password"),
        IsDeleted = false,
        CreationTimestamp = DateTime.Now.ToUniversalTime(),
        ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
        DeletedTimestamp = null,
        Roles = new List<Role> { RoleDataSeedService.AdminRole }
    };

    private readonly IUserRepository repository;

    public UserDataSeedService(IUserRepository repository)
    {
        this.repository = repository;
    }

    public async Task DataSeedAsync()
    {
        await repository.CreateOrUpdateRangeAsync(new List<User> { User0 });
    }
}