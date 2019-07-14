using System.Collections.Generic;

namespace DotnetBlackJack.Entities
{
    public class Table
    {
        public Deck Deck { get; set; }
        public List<Card> DealerCards { get; set; }
        public List<Card> PlayerCards { get; set; }
        public int Bet { get; set; }
        public int PlayerFunds { get; set; }
        public bool PlayerStands { get; set; }
        public bool DealerStands { get; set; }
    }
}
