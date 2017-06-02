namespace DatingApp.Models
{
    public class Device : DomainBase
    {
        public string DeviceId { get; set; }
        public Location Location { get; set; }
    }
}