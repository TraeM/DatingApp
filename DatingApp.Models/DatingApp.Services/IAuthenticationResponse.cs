using DatingApp.Models;

namespace DatingApp.Services
{
    public interface IAuthenticationResponse
    {
        AuthToken AuthToken { get; set; }
    }
}