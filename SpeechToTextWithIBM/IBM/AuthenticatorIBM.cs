using IBM.Cloud.SDK.Core.Authentication.Iam;

namespace IBM
{
    public class AuthenticatorIBM{
        private IamAuthenticator _authenticatorIBM;

        public AuthenticatorIBM(string apiKey)
        {
            _authenticatorIBM = new IamAuthenticator(apiKey);
        }

        public IamAuthenticator GetAuthenticator() => _authenticatorIBM;
    }
}