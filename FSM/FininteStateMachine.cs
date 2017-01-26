using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class FiniteStateMachine<T>
    {
        private State currentState;
        private Dictionary<string, State> states;
        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();
        public FiniteStateMachine() { }
        public void AddState(Enum e)
        {
            State s = new State(e);
            states.Add(s.Name, s);
        }
        /// <summary>
        /// Takes in two states as enums and adds them on to a list 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool AddTransition(T a, T b)
        {
            State s1 = new State(a as Enum);
            State s2 = new State(b as Enum);
            List<State> tmp = new List<State>();
            tmp.Add(s1);
            tmp.Add(s2);
            transitions.Add(tmp[0].Name + "->" + tmp[1].Name, tmp);
            return true;
        }
        /// <summary>
        /// Takes in a state and sets it as the current state
        /// </summary>
        /// <param name="state"></param>
        public void Start(T state)
        {
            string name = (state as Enum).ToString();
            currentState = states[name];
        }
        /// <summary>
        /// Sets the current state to the next state and invokes the exit and enter
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(T state)
        {
            string key = currentState.ToString() + "->" + (state as Enum).ToString();
            if (transitions[key] != null)
            {
                currentState.onExit.Invoke();
                currentState = states[(state as Enum).ToString()];
                currentState.onEnter.Invoke();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public State GetState(T e)
        {
            State s = new State(e as Enum);
            string key = (s).Name;
            return states[key];
        }
    }
}
