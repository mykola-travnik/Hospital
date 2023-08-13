using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Business;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    private const string KEY = "mysupersecret_secretkey!1236546544564454464546545645645"; // ключ для шифрации

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}