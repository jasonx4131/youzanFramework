using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youzanFramework.api
{
    public interface IApiParams
    {
        IDictionary<string, string> ToParams();
    }
}
