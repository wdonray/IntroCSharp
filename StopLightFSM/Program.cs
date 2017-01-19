using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLightFSM.Classes;
using System.Diagnostics;

namespace StopLightFSM
{
    public enum LightState
    {
        INIT = 0,
        RED = 1,
        GREEN = 2,
        YELLOW = 3,
        EXIT = 9000,
    }
    class Program
    {
        static void Main(string[] args)
        {
            FSM
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                FSM.FeedMachine.sw.Elapsed.Seconds);
                Console.Clear();
            }
        }
        public void Print()
        {

        }
    }
}
