using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Player
    {
        public Player(string name, IHand hand)
        {
            Name = name;
            Hand = hand;
        }

        public string Name { get; }
        public IHand Hand { get; }
    }
}
