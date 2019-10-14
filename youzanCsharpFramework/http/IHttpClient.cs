using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youzanCsharpFramework.http
{
    public interface IHttpClient
    {

        /**
         * 发送请求接口
         */
        string Send(string url, IDictionary<string, string> apiParams, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files);
    }
}
