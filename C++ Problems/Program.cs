using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n");
            for (int i = 100; i >= 0; i--)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n");
            for (int i = 99; i >= 0; i--)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n");
            for (int i = 100; i > 0; i--)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n");
            for (int i = 100; i >= 2; i -= 2)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("\n\n");
            int x = 100;
            while (x > 0)
            {
                Console.Write(x);
                Console.Write(" ");
                x--;
            }
            int o = 100;
            while (o >= 0)
            {
                Console.Write(o);
                Console.Write(" ");
                o--;
            }
            int p = 99;
            while (p >= 0)
            {
                Console.Write(p);
                Console.Write(" ");
                p--;
            }
            int u = 100;
            while (u > 0)
            {
                Console.Write(u);
                Console.Write(" ");
                u--;
            }
            int bloop = 1;
            while (bloop <= 100)
            {
                if (bloop % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (bloop % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (bloop % 3 == 0 && bloop % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(bloop);
                }
                bloop++;
            }
            int sum2 = 0;
            int bla = 0;
            while (bla < 1000)
            {
                if (bla % 3 == 0 || bla % 5 == 0)
                {
                    sum2 += bla;
                }
                bla++;
            }
            Console.WriteLine(sum2);
            Console.Read();
        }
    }
}
