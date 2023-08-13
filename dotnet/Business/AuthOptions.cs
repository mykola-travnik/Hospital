using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Business;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    private const string KEY = "F5qQ4fClnsPdYkhcNiSrzOcSNd90OXhMdwI0LB7qWCkQyUPyV8"; // ключ для шифрации

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}