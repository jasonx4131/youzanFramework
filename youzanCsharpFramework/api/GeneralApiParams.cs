using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youzanCsharpFramework.api
{
    public class GeneralApiParams : IApiParams
    {
        private Dictionary<string, string> apiParams = new Dictionary<string, string>();

        public GeneralApiParams()
        {
        }

        IDictionary<string, string> IApiParams.ToParams()
        {
            return apiParams;
        }

        public void AddParam(string name, string value)
        {
            apiParams.Add(name, value);
        }
    }
}
