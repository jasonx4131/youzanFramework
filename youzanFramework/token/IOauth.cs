using static youzanFramework.token.OauthToken;

namespace youzanFramework.token
{
    public interface IOauth
    {
        TokenData GetToken();
    }
}
