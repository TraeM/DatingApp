using System.Net;

namespace DatingApp.Models
{
    public class AuthenticationCredentials : NetworkCredential, IDomain, IAuthenticationCredentials
    {
        public AuthToken Token { get; set; }
        public uint Id { get; set; }
    }
}