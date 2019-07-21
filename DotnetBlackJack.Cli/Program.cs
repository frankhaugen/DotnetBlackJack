using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotnetBlackJack.Entities;
using DotnetBlackJack.Extensions;

namespace DotnetBlackJack.Cli
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("\U0001F0D1");
            Console.WriteLine(Encoding.UTF8.GetString(Encoding.UTF8.GetBytes("\U0001F0D1")));

            var handler = new RoundHandler();
            handler.Start();
        }


        
    }
}
