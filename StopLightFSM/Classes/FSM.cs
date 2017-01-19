using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightFSM.Classes;

namespace StopLightFSM.Classes
{
    class FSM
    {
        public Dictionary<State, List<Transition>> dictionary = new Dictionary<State, List<Transition>>();
        public FSM () { }
        public void ChangeState(State s)
        {

        }
        enum LightState
        {
            INIT = 0,
            RED = 1,
            GREEN = 2,
            YELLOW = 3,
            EXIT = 9000,
        }

    }
}
