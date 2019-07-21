using System.Collections.Generic;
using System.Linq;
using DotnetBlackJack.Entities;

namespace DotnetBlackJack
{
    public class Rules
    {
        public bool IsBlackjack(List<Card> hand)
        {
            if (hand.Find(c => c.Name == "Ace"))
            {
                
            }


            var sum = hand.Select(h => h.Value).Sum();




            if (hand.Count == 2 && sum == 21)
            {
                return true;
            }

            return false;
        }

        public bool IsBust(List<Card> hand)
        {
            var sum = hand.Select(h => h.Value).Sum();

            if (sum > 21)
            {
                return true;
            }

            return false;
        }

        public bool ShouldStand(List<Card> hand)
        {
            var sum = hand.Select(h => h.Value).Sum();

            if (sum > 15)
            {
                return true;
            }

            return false;
        }

        public bool DealerHasMore(List<Card> dealerCards, List<Card> playerCards)
        {
            var dealerSum = dealerCards.Select(dc => dc.Value).Sum();
            var playerSum = playerCards.Select(pc => pc.Value).Sum();

            if (dealerSum > playerSum)
            {
                return true;
            }

            return false;
        }

        public bool PlayerHasMore(List<Card> dealerCards, List<Card> playerCards)
        {
            var dealerSum = dealerCards.Select(dc => dc.Value).Sum();
            var playerSum = playerCards.Select(pc => pc.Value).Sum();

            if (playerSum > dealerSum)
            {
                return true;
            }

            return false;
        }
    }
}
