using DatingApp.Models;

namespace DatingApp.Services
{
    public interface IAuthenticationRequest
    {
        IAuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}