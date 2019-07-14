using DotnetBlackJack.Enums;
using DotnetBlackJack.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace DotnetBlackJack.Entities
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }
        private readonly Dictionary<string, int> _cards = new Dictionary<string, int>() { { "Ace", 1 }, { "Two", 2 }, { "Three", 3 }, { "Four", 4 }, { "Five", 5 }, { "Six", 6 }, { "Seven", 7 }, { "Eight", 8 }, { "Nine", 9 }, { "Ten", 10 }, { "Jack", 10 }, { "Queen", 10 }, { "King", 10 } };
        private readonly List<Suits> _suits = new List<Suits>() { Suits.Clubs, Suits.Diamonds, Suits.Hearts, Suits.Spades };

        public Deck(int numberOfDecks = 1)
        {
            Cards = new List<Card>();

            if (numberOfDecks <= 1)
            {
                CreateDeck();
            }
            else
            {
                for (int i = 0; i < numberOfDecks; i++)
                {
                    CreateDeck();
                }
            }
        }

        public int Count => Cards.Count;

        public void Shuffle()
        {
            Cards = Cards.Shuffle().ToList();
        }

        public void Remove() => Cards.Shuffle();

        private void CreateDeck()
        {
            foreach (var suit in _suits)
            {
                foreach (var card in _cards)
                {
                    Cards.Add(new Card()
                    {
                        Suit = suit,
                        Name = card.Key,
                        Value = card.Value
                    });
                }
            }
        }
    }
}