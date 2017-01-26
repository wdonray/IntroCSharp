using System;
using System.Diagnostics;

namespace RedlightFSM
{
    class LightFSM
    {
        public Stopwatch stopwatch;
        public LightState current;

        public LightFSM(Stopwatch s)
        {
            stopwatch = s;
        }
        private void ChangeState(LightState s)
        {
            current = s;
        }

        public void Start()
        {
            ChangeState(LightState.INIT);
        }

        public void Update()
        {
            if (current == LightState.INIT)
            {
                current = LightState.RED;
                Console.WriteLine(current.ToString());
                stopwatch.Start();
            }

            if (stopwatch.Elapsed.Seconds > 5 && current == LightState.RED)
            {
                current = LightState.GREEN;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }

            if (stopwatch.Elapsed.Seconds > 5 && current == LightState.GREEN)
            {
                current = LightState.YELLOW;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }

            if (stopwatch.Elapsed.Seconds > 2 && current == LightState.YELLOW)
            {
                current = LightState.RED;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }
        }
    }
}