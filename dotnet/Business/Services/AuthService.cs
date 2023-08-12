namespace Business.Services
{
    public class AuthService
    {
        private readonly IUserService userService;

        public AuthService(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<string> LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }
        public async Task<UserDto> SignIn(string username, string password)
        {
            throw new NotImplementedException();
            //var newUser = new UserCreateDto() { Name = username, Roles = new()}
        }

    }
}
