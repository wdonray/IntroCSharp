using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RedlightFSM
{
    public enum LightState
    {
        INIT = -1, RED = 0, GREEN = 1, YELLOW = 2, EXIT = 3,
    }

    class Program
    {
        static void LightTest()
        {
            Stopwatch timer = new Stopwatch();

            LightFSM LightFSM = new LightFSM(timer);

            LightFSM.Start();

            while (true)
            {
                LightFSM.Update();
            }
        }

        static void Main(string[] args)
        {
            LightTest();
        }
    }
}