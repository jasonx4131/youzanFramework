using System.Collections.Generic;
using youzanCsharpFramework.api;
using youzanCsharpFramework.auth;

namespace youzanCsharpFramework.core
{
    public interface IYouZanClient
    {
        string Invoke(IAPI api, IAuth auth,IDictionary<string, string> headers, List<KeyValuePair<string, string>> files);

    }
}
