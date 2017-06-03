using System.Collections.Generic;

using DatingApp.Data.Domain.Base;

namespace DatingApp.Data.Dto
{
    public class CardContiner : DomainBase
    {
        public Stack<Card> CardStack { get; set; }
    }
}