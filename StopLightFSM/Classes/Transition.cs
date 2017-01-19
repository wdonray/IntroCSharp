using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightFSM.Classes;

namespace StopLightFSM.Classes
{
    class Transition
    {
        public string input { get; private set; }

        public State dest { get; private set; }

        public Transition(string token, State t)
        {
            input = token;
            dest = t;
        }

    }
}
