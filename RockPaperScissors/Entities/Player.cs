using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Player : ICanBeat
    {
        public IHand Hand { get; set; }

        public bool Beat(ICanBeat canBeat)
        {
            if (Hand == null)
                return false;
            return Hand.TryBeat(canBeat.Hand);
        }
    }
}
