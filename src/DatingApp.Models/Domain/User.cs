using System.Collections.Generic;

using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Domain
{
    public class User : DomainBase
    {
        public Profile Profile { get; set; }
        public IEnumerable<Interest> Interests { get; set; }
    }
}