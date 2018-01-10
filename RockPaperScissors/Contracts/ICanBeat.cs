using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    public interface ICanBeat
    {
        IHand Hand { get; set; }
        bool Beat(ICanBeat canBeat);
    }
}
