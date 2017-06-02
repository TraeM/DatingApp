using DatingApp.Models;

namespace DatingApp.Services
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