using DatingApp.Data.Domain.Base;
using DatingApp.Data.Dto;

namespace DatingApp.Data.Domain
{
    public class Session : DomainBase
    {
        public uint UserId { get; set; }
        public int DeviceId { get; set; }
        public uint AuthId { get; set; }
        public AuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}