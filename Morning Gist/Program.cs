using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Gist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add(i);
                }
            }
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    numbers.Remove(i);
                }
            }
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
