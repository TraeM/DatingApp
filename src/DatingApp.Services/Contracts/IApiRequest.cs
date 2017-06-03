using DatingApp.Data.Contracts.Domain;

namespace DatingApp.Services.Contracts
{
    public interface IApiRequest : IAuthenticationRequest
    {
        IDomain Payload { get; }
    }
}