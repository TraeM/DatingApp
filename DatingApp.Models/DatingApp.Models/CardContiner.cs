using System.Collections.Generic;

namespace DatingApp.Models
{
    public class CardContiner : DomainBase
    {
        public Stack<Card> CardStack { get; set; }
    }
}