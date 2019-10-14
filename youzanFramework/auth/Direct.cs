using youzanFramework.common.constant;

namespace youzanFramework.auth
{
    public class Direct : IAuth
    {
        public Direct() { }

        OAuthEnum IAuth.GetType()
        {
            return OAuthEnum.DIRECT;
        }
    }
}
