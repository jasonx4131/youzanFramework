using System.Collections.Generic;
using youzanFramework.api;
using youzanFramework.auth;

namespace youzanFramework.core
{
    public interface IYouZanClient
    {
        string Invoke(IAPI api, IAuth auth,IDictionary<string, string> headers, List<KeyValuePair<string, string>> files);

    }
}
