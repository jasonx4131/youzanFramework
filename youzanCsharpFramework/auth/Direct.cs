using youzanCsharpFramework.common.constant;

namespace youzanCsharpFramework.auth
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
