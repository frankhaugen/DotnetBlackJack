using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetBlackJack.Extensions
{
    public static class StackExtensions
    {
        public static Stack<T> Shuffle<T>(this Stack<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy(arg => rnd) as Stack<T>;
        }
    }
}
