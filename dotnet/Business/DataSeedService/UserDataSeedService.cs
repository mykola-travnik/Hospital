using Data.Repositories;
using Domain.Models;

namespace Business.DataSeedService;

public class UserDataSeedService : IUserDataSeedService
{
    public static User Admin = new()
    {
        Id = Guid.Parse("FCD5A2F2-2E48-4620-A843-F8E0D82BC109"),
        Name = "admin",
        Password = HashHelpers.GetHashString("admin"),
        IsDeleted = false,
        CreationTimestamp = DateTime.Now.ToUniversalTime(),
        ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
        DeletedTimestamp = null,
        Roles = new List<Role> { RoleDataSeedService.AdminRole }
    };

    public static User User = new()
    {
        Id = Guid.Parse("F790C5D9-B614-4B39-80E9-DE46D54C1E95"),
        Name = "user",
        Password = HashHelpers.GetHashString("user"),
        IsDeleted = false,
        CreationTimestamp = DateTime.Now.ToUniversalTime(),
        ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
        DeletedTimestamp = null,
        Roles = new List<Role> { RoleDataSeedService.UserRole }
    };


    private readonly IUserRepository repository;

    public UserDataSeedService(IUserRepository repository)
    {
        this.repository = repository;
    }

    public async Task DataSeedAsync()
    {
        await repository.CreateOrUpdateRangeAsync(new List<User> { Admin, User });
    }
}