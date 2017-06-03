using DatingApp.Data.Domain;

namespace DatingApp.Services.Contracts
{
    public interface IAuthenticationResponse
    {
        AuthToken AuthToken { get; set; }
    }
}