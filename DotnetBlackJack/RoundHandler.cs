using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotnetBlackJack.Entities;
using DotnetBlackJack._debugger;
using DotnetBlackJack.Extensions;

namespace DotnetBlackJack
{
    public class RoundHandler
    {
        private DebugDataObject _debugger = new DebugDataObject();
        private DeckManager _deckManager = new DeckManager();
        private Rules _rules = new Rules();

        private List<Card> _discard = new List<Card>();
        private Table table = new Table();

        public void Start()
        {
            SetupTable();

            PlayRound();

        }

        private void SetupTable()
        {
            table.DealerCards = new List<Card>();
            table.PlayerCards = new List<Card>();
            table.Deck = _deckManager.GenerateCardDecks();
        }

        private void PlayRound()
        {
            table.Deck.Shuffle(64);

            DrawCard(table.DealerCards);
            DrawCard(table.DealerCards);
            DrawCard(table.PlayerCards);
            DrawCard(table.PlayerCards);

            DisplayCards(table.DealerCards, true);
            DisplayCards(table.PlayerCards);

            CheckForBlackJack();

            while (table.Deck.Count > 0)
            {
                Console.WriteLine("Hit enter to continue");
                Console.ReadLine();

                DisplayCards(table.DealerCards, true);
                DisplayCards(table.PlayerCards);
            }
        }

        private void DrawCard(List<Card> drawer)
        {
            _discard.Add(table.Deck.FirstOrDefault());
            drawer.Add(table.Deck.FirstOrDefault());

            table.Deck.Remove(table.Deck.FirstOrDefault());
        }
        
        private void DisplayCards(List<Card> cards, bool isDealersFirstRound = false)
        {
            if (!isDealersFirstRound)
            {
                foreach (var card in cards)
                {
                    DisplayCard(card);
                }
                Console.WriteLine($"Total value of cards: {cards.ToList().Sum(card => card.Value)}");
            }
            else
            {
                foreach (var card in cards.Skip(1))
                {
                    DisplayCard(card);
                }
                Console.WriteLine($"Total value of cards: {cards.ToList().Skip(1).Sum(card => card.Value)}");
            }
        }

        private void DisplayCard(Card card)
        {
            Console.WriteLine($"{card.FullName}\t{card.Value}");
        }

        private void CheckForBlackJack()
        {
            if (_rules.IsBlackjack(table.DealerCards))
            {
                Console.WriteLine("Dealer has blackjack");
            }
            if (_rules.IsBlackjack(table.PlayerCards))
            {
                Console.WriteLine("Player has blackjack");
            }
        }


    }
}
