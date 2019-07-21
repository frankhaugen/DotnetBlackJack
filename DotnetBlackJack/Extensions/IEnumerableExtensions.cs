using System;
using System.Collections.Generic;
using System.Linq;
using DotnetBlackJack.Entities;

namespace DotnetBlackJack.Extensions_
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy((item) => rnd.Next());
        }

        public static IEnumerable<TCard> Shuffle<TCard>(this IEnumerable<TCard> source)
        {
            Random rnd = new Random();
            return source.OrderBy<TCard, int>((item) => rnd.Next());
        }

        public static TCard Draw<TCard>(this IEnumerable<TCard> source)
        {
            var topCard = source.GetFirst();
            source.RemoveFirst();

            return topCard;
        }

        public static void RemoveFirst<T>(this IEnumerable<T> source)
        {
            if (source.Any())
            {
                source.ToList().RemoveAt(0);
            }
        }

        public static T GetFirst<T>(this IEnumerable<T> source)
        {
            if (source.Any())
            {
                return source.ToList().ElementAt(0);
            }

            throw new ArgumentNullException();
        }
    }
}
