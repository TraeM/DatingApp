using System.Collections.Generic;

using DatingApp.Data.Contracts.Domain;
using DatingApp.Data.Domain;
using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Dto
{
    public class Conversation : DomainBase, IDeletable
    {
        public IEnumerable<Message> SenderMessages { get; set; }
        public IEnumerable<Message> RecieverMessages { get; set; }
        public bool? IsDeleted { get; set; }
    }
}