using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    public enum Light
    {
        INIT = 0,
        RED = 1,
        GREEN = 2,
        YELLOW = 3,
        EXIT = 4,
    }
    public delegate void Callback();
    class Program
    {
        class LightBehaviour
        {
            static public void RedLight() { Console.WriteLine("Red Light"); }
            static public void GreenLight() { Console.WriteLine("Green Light"); }
            static public void YellowLight() { Console.WriteLine("Yellow Light"); }
            static public void Init() { Console.WriteLine("We On"); }
        }
        static void Main(string[] args)
        {
            FiniteStateMachine<Light> FSM = new FiniteStateMachine<Light>();

            FSM.AddState(Light.INIT);
            FSM.AddState(Light.RED);
            FSM.AddState(Light.GREEN);
            FSM.AddState(Light.YELLOW);

            FSM.AddTransition(Light.INIT, Light.RED);
            FSM.AddTransition(Light.RED, Light.GREEN);
            FSM.AddTransition(Light.GREEN, Light.YELLOW);
            FSM.AddTransition(Light.YELLOW, Light.RED);

            FSM.GetState(Light.INIT).AddEnter((Callback)LightBehaviour.Init);
            FSM.GetState(Light.RED).AddEnter((Callback)LightBehaviour.RedLight);
            FSM.GetState(Light.GREEN).AddEnter((Callback)LightBehaviour.GreenLight);
            FSM.GetState(Light.YELLOW).AddEnter((Callback)LightBehaviour.YellowLight);

            FSM.GetState(Light.INIT).AddExit((Callback)LightBehaviour.Init);
            FSM.GetState(Light.RED).AddExit((Callback)LightBehaviour.RedLight);
            FSM.GetState(Light.GREEN).AddExit((Callback)LightBehaviour.GreenLight);
            FSM.GetState(Light.YELLOW).AddExit((Callback)LightBehaviour.YellowLight);

            FSM.Start(Light.INIT);

            while (true)
            {
                FSM.Update();
            }

        }
    }
}
