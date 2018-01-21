using RockPaperScissors.Entities;

namespace RockPaperScissors.Contracts
{
    public interface IHand
    {
        ActionEnum Weakness { get; }
        ActionEnum Strength { get; }
    }
}
