using System.Collections.Generic;

using DatingApp.Data.Contracts.Domain;
using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Domain
{
    public class Profile : DomainBase, IDeletable
    {
        public string Bio { get; set; }
        public Person Person { get; set; }
        public IEnumerable<ProfileImage> ProfileImages { get; set; }
        public IEnumerable<uint> Matches { get; set; }
        public IEnumerable<uint> BlockedUsers { get; set; }
        public bool? IsDeleted { get; set; }
    }
}