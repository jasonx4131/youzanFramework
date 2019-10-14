using System;
using youzanCsharpFramework.api;
using youzanCsharpFramework.auth;
using youzanCsharpFramework.common.constant;
using youzanCsharpFramework.core;
using youzanCsharpFramework.token;

namespace youzanFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Silent silent = new Silent("c93c8366df87d6d8e2", "ccb43a58999d72840edcf1fcfdf58be9", 44538248);
            OauthToken.TokenData silenToken = silent.GetToken();
            string token = silenToken.Token;

            //构建请求API
            GeneralApi generalApi = new GeneralApi();
            //设置请求参数
            GeneralApiParams apiParams = new GeneralApiParams();
            apiParams.AddParam("page_no", "1");
            apiParams.AddParam("page_size", "100");
            generalApi.SetAPIParams(apiParams);
            //设置API名称
            generalApi.SetName("youzan.ump.coupon.search");
            //设置API版本号
            generalApi.SetVersion("3.0.0");
            //指定鉴权类型
            generalApi.SetOAuthType(OAuthEnum.TOKEN);
            IYouZanClient defaultYZClient = new DefaultYZClient();
            //请求接口
            string result = defaultYZClient.Invoke(generalApi, new Token(token), null, null);
            Console.WriteLine("request result *******************" + result);
        }
    }
}
