using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightFSM.Classes;

namespace StopLightFSM.Classes
{
    class State
    {
        public delegate void OnStartState();
        OnStartState onStartState;

        public void OnStart()
        {
            if (onStartState != null)
                onStartState.Invoke();
        }
        public Enum name;
        public Delegate del;
        public State () { }
        public State (Enum stateName, Delegate stateHandler)
        {
            name = stateName;
            del = stateHandler;
        } 
    }
}
