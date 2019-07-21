using DotnetBlackJack.Enums;

namespace DotnetBlackJack.Entities
{
    public class Card
    {
        public string Name { get; set; }
        public string FullName => $"{Name} of {Suit.ToString()}";
        public Suits Suit { get; set; }
        public int Value { get; set; }
        public string Character { get; set; }
    }
}
