namespace DatingApp.Models
{
    public class Person : DomainBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public Gender Gender { get; set; }
    }
}