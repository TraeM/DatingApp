using DatingApp.Models;

namespace DatingApp.Services
{
    public class AuthenticationResponse : ApiResponse, IAuthenticationResponse
    {
        public AuthToken AuthToken { get; set; }
    }
}