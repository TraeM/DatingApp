using System;

namespace DatingApp.Models
{
    public class AuthToken : DomainBase
    {
        public DateTime Created { get; set; }
        public TimeSpan TimeToExpiration { get; set; }
        public bool IsExpired { get; set; }
    }
}