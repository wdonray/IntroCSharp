using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Gist
{
    //List<int> numbers = new List<int>();
    //        for (int i = 1; i <= 100; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                numbers.Add(i);
    //            }
    //        }
    //        foreach (int x in numbers)
    //        {
    //            Console.WriteLine(x);
    //        }
    //        for (int i = 1; i <= 100; i++)
    //        {
    //            if (i % 10 == 0)
    //            {
    //                numbers.Remove(i);
    //            }
    //        }
    //        foreach (int x in numbers)
    //        {
    //            Console.WriteLine(x);
    //        }
    //        Console.Read();
    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value, tail, head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get { return head; }
            }

            public string Tail
            {
                get { return tail; }
            }
        }

        static string BinaryString(string s)
        {
            Gene g = new Gene(s);
            string str = "";
            foreach (var v in g.Tail)
            {
                str += Invert(v);
            }
            str += g.Tail;
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input: 11110011, Output: " + BinaryString("11110011"));
            Console.WriteLine("Input: 01110000, Output: " + BinaryString("01110000"));
            Console.WriteLine("Input: 11010101, Output: " + BinaryString("11010101"));
            Console.Read();
        }
    }
}

