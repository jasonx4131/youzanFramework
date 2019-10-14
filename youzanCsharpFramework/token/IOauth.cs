using static youzanCsharpFramework.token.OauthToken;

namespace youzanCsharpFramework.token
{
    public interface IOauth
    {
        TokenData GetToken();
    }
}
