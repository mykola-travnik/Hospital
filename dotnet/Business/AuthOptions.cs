using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Business;

public static class AuthOptions
{
    public static string ISSUER = "MyAuthServer"; // издатель токена
    public static string AUDIENCE = "MyAuthClient"; // потребитель токена
    public static string KEY = "F5qQ4fClnsPdYkhcNiSrzOcSNd90OXhMdwI0LB7qWCkQyUPyV8"; // ключ для шифрации
    public static string USERNAME_CLAIM = "username";
    public static string USER_ROLES_CLAIM = "roles";

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}