using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Paper : IHand
    {
        public bool CanBeCrushed()
        {
            return false;
        }

        public bool CanBeCovered()
        {
            return false;
        }

        public bool CanBeCut()
        {
            return true;
        }

        public bool TryBeat(ICanBe canBe)
        {
            return canBe.CanBeCovered();
        }
    }
}
