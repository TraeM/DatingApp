using System.Net;

namespace DatingApp.Models
{
    public interface IAuthenticationCredentials : ICredentials
    {
        AuthToken Token { get; set; }
    }
}