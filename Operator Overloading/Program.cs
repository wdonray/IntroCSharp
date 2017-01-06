using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVar
    {
        void Log();
        void Number();
    }
    public class Square : IVar
    {
        public string name;
        public string Name { get { return name; } set { name = value; } }
        public int size;
        public int Size { get { return size; } set { size = value; } }
        public void Log() { Console.WriteLine("My name is " + name + " and I am a square!"); }
        public void Number() { Console.WriteLine(size); }
    }
    public class Donray : IVar
    {
        public int cash;
        public int Cash { get { return cash; } set { cash = value; } }

        public string phoneNumber;
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public void Log()
        {
            if (cash >= 500)
            {
                Console.WriteLine("You currently have : " + cash + " you are stable for now.");
            }
            else
            {
                Console.WriteLine("You currently have : " + cash + " you are not stable for now.");
            }
        }
        public void Number() { Console.WriteLine(phoneNumber); }
    }
    class Calculator : IVar
    {
        List<int> sum = new List<int>();
        public void Number()
        {
            sum.Add(3 + 902);
            sum.Remove(905);
            sum.Add(8 / 2 + 70);
        }
        public void Log()
        {
            for (int i = 0; i < sum.Count; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Square();
            test.Name = "test";
            test.Size = 2;
            test.Log();
            test.Number();
            var me = new Donray();
            me.Cash = 500;
            me.PhoneNumber = "337-501-5376";
            me.Log();
            me.Number();
            var work = new Calculator();
            work.Number();
            work.Log();
            Console.Read();
        }
    }
}
