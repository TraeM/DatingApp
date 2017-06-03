using DatingApp.Data.Contracts.Auth;
using DatingApp.Data.Contracts.Domain;
using DatingApp.Services.Contracts;

namespace DatingApp.Services.Request
{
    public class ApiRequest<T> : IApiRequest where T : IDomain
    {
        protected ApiRequest(T payload)
        {
            Payload = payload;
        }

        public IDomain Payload { get; }
        public IAuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}