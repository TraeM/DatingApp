using System.Net;

using DatingApp.Data.Contracts.Auth;
using DatingApp.Data.Contracts.Domain;
using DatingApp.Data.Domain;

namespace DatingApp.Data.Dto
{
    public class AuthenticationCredentials : NetworkCredential, IDomain, IAuthenticationCredentials
    {
        public AuthToken Token { get; set; }
        public uint Id { get; set; }
    }
}