﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Mediator
{
    /// </summary>
    class NonBeatle : Participant
    {
        // Constructor
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
