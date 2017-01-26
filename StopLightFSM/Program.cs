using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace FSMExample
{
    public enum LightState
    {
        INIT = 0,
        RED = 1,
        GREEN = 2,
        YELLOW = 3,
        EXIT = 4,
    }
    class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;

        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
    }

    class FSM<T>
    {
        public FSM()
        {
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v)
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
            }
        }

        Dictionary<string, State> states;
        State cState;
        public void ChangeState(State state)
        {
            if (isValidTransition(state))
            {
                cState.onExit();
                cState = state;
                cState.onEnter();
            }
        }
        public bool AddState(State state)
        {
            if (states.Count == 0)
            {
                states.Add(state.name, state);
                return true;
            }
            else if (states.ContainsKey(state.name) == false)
            {
                states.Add(state.name, state);
                return true;
            }
            return false;
        }
        public bool AddTransition<V>(V a, V b)
        {
            //FSM fsm = new FSM();
            //State init = new State();
            //State idle = new State();
            //fsm.AddState(init);
            //fsm.AddState(idle);
            //usage would be fsm.AddTransition(init, idle)

            //access the transitions for the state

            State c = new State(a as Enum);
            State s = new State(b as Enum);
            List<State> tmp = new List<State>();
            tmp.Add(c);
            tmp.Add(s);
            transitions.Add(transitions.Count.ToString(), tmp);
            return true;
        }
        public State GetState(T e)
        {
            State s = new State(e as Enum);
            string key = (e as State).name;
            return states[key];
        }
        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();
      
        public bool Start() { return true; }

        public bool Update() { return true; }
    }
    class Program
    {
        class LightBehaviour
        {
            static public void RedLightBehaviour()
            {
                Console.WriteLine("I'm at the Red Light");
            }
            static public void GreenLightBehaviour()
            {
                Console.WriteLine("I'm at the Green Light");
            }
            static public void YellowLightBehaviour()
            {
                Console.WriteLine("I'm at the Yellow Light");
            }
        }
        public delegate void Handler();
        static void Main(string[] args)
        {
            FSM<LightState> trafficFSM = new FSM<LightState>();

            trafficFSM.AddState(new State(LightState.INIT));
            trafficFSM.AddState(new State(LightState.RED));
            trafficFSM.AddState(new State(LightState.GREEN));
            trafficFSM.AddState(new State(LightState.YELLOW));

            trafficFSM.AddTransition(LightState.INIT, LightState.RED);
            trafficFSM.AddTransition(LightState.RED, LightState.GREEN);
            trafficFSM.AddTransition(LightState.GREEN, LightState.YELLOW);
            trafficFSM.AddTransition(LightState.YELLOW, LightState.RED);

            trafficFSM.GetState(LightState.RED).AddEnterFunction((Handler)LightBehaviour.RedLightBehaviour);
            trafficFSM.GetState(LightState.GREEN).AddEnterFunction((Handler)LightBehaviour.GreenLightBehaviour);
            trafficFSM.GetState(LightState.YELLOW).AddEnterFunction((Handler)LightBehaviour.YellowLightBehaviour);

            trafficFSM.Start();

            while (true)
            {
                trafficFSM.Update();
            }
        }
    }
}