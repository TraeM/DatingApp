using System.Collections.Generic;

namespace DatingApp.Models
{
    public class User : DomainBase
    {
        public Profile Profile { get; set; }
        public IEnumerable<Interest> Interests { get; set; }
    }
}