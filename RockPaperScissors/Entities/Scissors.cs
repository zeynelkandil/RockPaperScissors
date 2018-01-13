using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Scissors : IHand
    {
        public ActionEnum Weakness => ActionEnum.Smash;

        public ActionEnum Strength => ActionEnum.Cut;
    }
}
