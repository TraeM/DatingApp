using System.Collections.Generic;

namespace DatingApp.Models
{
    public class Profile : DomainBase, IDeletable
    {
        public Person Person { get; set; }
        public IEnumerable<uint> Matches { get; set; }
        public IEnumerable<uint> BlockedUsers { get; set; }
        public ushort ApproximateDistance { get; set; }
        public IEnumerable<ProfileImage> ProfileImages { get; set; }
        public bool IsDeleted { get; set; }
    }
}