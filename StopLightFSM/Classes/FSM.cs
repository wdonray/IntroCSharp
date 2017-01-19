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
        public FSM() { }
        public void StartMachine()
        {

        }
        public void FeedMachine(int input)
        {
            //switch (input)
            //{
            //    case -1:
            //        break;
            //}
            string output = input.ToString();
            if (input % 10 == 0)
                Console.WriteLine(output);

        }
        public void EndMachine()
        {

        }

        private State currentState;
        private List<State> states;
    }
}
