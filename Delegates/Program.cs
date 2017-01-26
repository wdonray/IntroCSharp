using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Callback();
    public class Stick
    {
        public Stick()
        {
            onShout = null;
        }
        Callback onShout;
        public void AddFunction(Callback Function)
        {
            onShout += Function;
        }
        public void RemoveFunction(Callback Function)
        {
            onShout -= Function;
        }
        public void Voke()
        {
            if (onShout != null)
                onShout.Invoke();
        }
    }
    class Program
    {
       static public void SayStuff() { Console.WriteLine("Stuff"); }
       public static void SayStuff2() { Console.WriteLine("Stuff2"); }
        static void Main(string[] args)
        {
            Stick s = new Stick();
            s.AddFunction(SayStuff);
            s.AddFunction(SayStuff2);
            s.RemoveFunction(SayStuff);
            s.Voke();
            Console.Read();
        }
    }
}
