using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recersive_Function
{

    class Program
    {
        static int Fibonacci(int a)
        {
            if (a <= 1)
                return 1;
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.Read();
        }
    }
}
