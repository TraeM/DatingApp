using System.Net;

using DatingApp.Data.Domain;

namespace DatingApp.Data.Contracts.Auth
{
    public interface IAuthenticationCredentials : ICredentials
    {
        AuthToken Token { get; set; }
    }
}