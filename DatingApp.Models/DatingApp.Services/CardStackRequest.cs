using DatingApp.Models;

namespace DatingApp.Services
{
    public class CardStackRequest : IAuthenticationRequest
    {
        /// <inheritdoc />
        public IAuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}