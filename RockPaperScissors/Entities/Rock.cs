using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Rock : IHand
    {
        public ActionEnum Weakness => ActionEnum.Cover;

        public ActionEnum Strength => ActionEnum.Smash;
    }
}
