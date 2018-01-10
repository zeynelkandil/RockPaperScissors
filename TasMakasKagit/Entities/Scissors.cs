using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Scissors : IHand
    {
        public bool CanBeCrushed()
        {
            return true;
        }

        public bool CanBeCovered()
        {
            return false;
        }

        public bool CanBeCut()
        {
            return false;
        }

        public bool TryBeat(ICanBe canBe)
        {
            return canBe.CanBeCut();
        }
    }
}
