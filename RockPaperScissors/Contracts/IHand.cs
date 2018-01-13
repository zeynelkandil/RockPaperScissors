using RockPaperScissors.Entities;
using System.Collections.Generic;

namespace RockPaperScissors.Contracts
{
    public interface IHand
    {
        ActionEnum Weakness { get; }
        ActionEnum Strength { get; }
    }
}
