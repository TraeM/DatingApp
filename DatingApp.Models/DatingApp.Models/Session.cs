namespace DatingApp.Models
{
    public class Session : DomainBase
    {
        public User User { get; set; }
        public Device Device { get; set; }
        public AuthenticationCredentials AuthenticationCredentials { get; set; }
    }
}