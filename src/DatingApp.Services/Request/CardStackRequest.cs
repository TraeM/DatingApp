using DatingApp.Data.Contracts.Auth;
using DatingApp.Services.Contracts;

namespace DatingApp.Services.Request
{
    public class CardStackRequest : IAuthenticationRequest
    {
        /// <inheritdoc />
        public IAuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}