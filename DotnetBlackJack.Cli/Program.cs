using System;
using System.Collections.Generic;
using System.Linq;
using DotnetBlackJack.Entities;
using DotnetBlackJack.Extensions;

namespace DotnetBlackJack.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table()
            {
                Deck = new Deck(),
                PlayerFunds = 150
            };


            Console.WriteLine("Hello World!");

            //Console.Out.WriteLine(string.Join("\n", table.Deck.Cards.Select(c => c.FullName)));

            table.Deck.Shuffle();
            Console.Out.WriteLine(string.Join("\n", table.Deck.Cards.Select(c => c.FullName)));


            //Console.WriteLine("Hello World!");
        }
    }
}
