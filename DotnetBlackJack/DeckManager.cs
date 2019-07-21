using System;
using DotnetBlackJack.Entities;
using DotnetBlackJack.Enums;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using DotnetBlackJack.Constants;
using Newtonsoft.Json;

namespace DotnetBlackJack
{
    public class DeckManager
    {
        private readonly Dictionary<string, int> _cards = new Dictionary<string, int>() { { "Ace", 1 }, { "Two", 2 }, { "Three", 3 }, { "Four", 4 }, { "Five", 5 }, { "Six", 6 }, { "Seven", 7 }, { "Eight", 8 }, { "Nine", 9 }, { "Ten", 10 }, { "Jack", 10 }, { "Queen", 10 }, { "King", 10 } };
        private readonly List<Suits> _suits = new List<Suits>() { Suits.Clubs, Suits.Diamonds, Suits.Hearts, Suits.Spades };
        private List<Card> cards;

        public List<Card> GenerateCardDecks(int numberOfDecks = 1)
        {
            cards = new List<Card>();

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

            return cards;
        }

        private void CreateDeck()
        {
            foreach (var suit in _suits)
            {
                foreach (var card in _cards)
                {
                    var test = typeof(CardCharacters).GetNestedTypes();

                    var test2 = test.FirstOrDefault(t => t.Name == suit.GetType().GetEnumName(suit));
                    
                    var test3 = test2.GetField(card.Key).GetValue(null) as string;

                    //Debugger.Break();

                    cards.Add(new Card()
                    {
                        Suit = suit,
                        Name = card.Key,
                        Value = card.Value,
                        Character = test3
                    });
                }
            }
        }
    }
}
