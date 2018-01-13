using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Paper : IHand
    {
        public ActionEnum Weakness => ActionEnum.Cut;

        public ActionEnum Strength => ActionEnum.Cover;
    }
}
