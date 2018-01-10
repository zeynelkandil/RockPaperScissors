using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Rock : IHand
    {
        public bool CanBeCrushed()
        {
            return false;
        }

        public bool CanBeCovered()
        {
            return true;
        }

        public bool CanBeCut()
        {
            return false;
        }

        public bool TryBeat(ICanBe canBe)
        {
            return canBe.CanBeCrushed();
        }
    }
}
