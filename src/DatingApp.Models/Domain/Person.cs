using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Domain
{
    public class Person : DomainBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public Gender Gender { get; set; }
    }
}