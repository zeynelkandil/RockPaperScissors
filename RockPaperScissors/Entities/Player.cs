﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Contracts;

namespace RockPaperScissors.Entities
{
    public class Player
    {
        public Player(string name, IHand hand)
        {
            Name = name;
            Hand = hand;
            bool oldTest = false;
            if (oldTest)
                hand = null;
        }

        public string Name { get; }
        public IHand Hand { get; }
    }
}
