using System.Collections.Generic;

namespace DatingApp.Models
{
    public class Conversation : DomainBase, IDeletable
    {
        public IEnumerable<Message> SenderMessages { get; set; }
        public IEnumerable<Message> RecieverMessages { get; set; }
        public bool IsDeleted { get; set; }
    }
}