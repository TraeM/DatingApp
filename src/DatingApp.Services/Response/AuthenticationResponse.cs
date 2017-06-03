using DatingApp.Data.Domain;
using DatingApp.Services.Contracts;

namespace DatingApp.Services.Response
{
    public class AuthenticationResponse : ApiResponse, IAuthenticationResponse
    {
        public AuthToken AuthToken { get; set; }
    }
}