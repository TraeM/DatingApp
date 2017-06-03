using DatingApp.Data.Contracts.Auth;

namespace DatingApp.Services.Contracts
{
    public interface IAuthenticationRequest
    {
        IAuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}