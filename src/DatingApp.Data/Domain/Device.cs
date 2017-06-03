using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Domain
{
    public class Device : DomainBase
    {
        public string IMEI { get; set; }
        public Location Location { get; set; }
    }
}