using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Domain
{
    public class Interest : DomainBase
    {
        public string Name { get; set; }
        public uint Rating { get; set; }
    }
}