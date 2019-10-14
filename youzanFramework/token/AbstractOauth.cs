using static youzanFramework.token.OauthToken;

namespace youzanFramework.token
{
    public abstract class AbstractOauth : IOauth
    {
        private string tokenUrl = "https://open.youzanyun.com/auth/token";

        protected string clientId;

        protected string clientSecret;

        protected AbstractOauth(string clientId, string clientSecret)
        {
            //CheckUtils.CheckParams(clientId, clientSecret);
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        public void SetTokenUrl(string tokenUrl)
        {

            this.tokenUrl = tokenUrl;
        }


        public string GetTokenUrl()
        {

            return tokenUrl;
        }

        public abstract TokenData GetToken();
    }
}
