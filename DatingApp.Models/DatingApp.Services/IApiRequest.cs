using DatingApp.Models;

namespace DatingApp.Services
{
    public interface IApiRequest : IAuthenticationRequest
    {
        IDomain Payload { get; }
    }
}