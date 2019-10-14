using Newtonsoft.Json;
using System.Collections.Generic;
using youzanFramework.http;
using static youzanFramework.token.OauthToken;

namespace youzanFramework.token
{
    public class Silent : AbstractOauth
    {

        private ulong kdtId;

        public Silent(string clientId, string clientSecret, ulong kdtId) : base(clientId, clientSecret)
        {
            this.kdtId = kdtId;
        }

        public Silent(string clientId, string clientSecret) : base(clientId, clientSecret)
        {
        }

        public void SetKdtId(ulong kdtId)
        {

            this.kdtId = kdtId;
        }

        public override TokenData GetToken()
        {
            IDictionary<string, string> tokenParams = new Dictionary<string, string>
            {
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "authorize_type", "silent" },
                { "grant_id", kdtId.ToString() }
            };
            DefaultHttpClient defaultHttpClient = new DefaultHttpClient();
            string result = defaultHttpClient.Send(this.GetTokenUrl(), tokenParams, null, null);
            OauthToken oAuthToken = JsonConvert.DeserializeObject<OauthToken>(result);
            if (oAuthToken.Data == null)
            {
                TokenData tokenData = new TokenData
                {
                    Message = result
                };
                return tokenData;
            }
            string data = oAuthToken.Data.ToString();
            TokenData toKenData = JsonConvert.DeserializeObject<TokenData>(data);


            return toKenData;
        }
    }
}
