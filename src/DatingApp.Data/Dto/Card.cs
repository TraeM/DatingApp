using DatingApp.Data.Domain;
using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Dto
{
    public class Card : DomainBase
    {
        public User User { get; set; }
    }
}