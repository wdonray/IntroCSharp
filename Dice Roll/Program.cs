using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll
{
    class Player
    {
        public Player() { }
        public Player(string name, int userGuess, int otherGuess)
        {
            m_name = name;
            m_userGuess = userGuess;
            m_otherGuess = otherGuess;
        }
        public string m_name;
        public int m_userGuess, m_otherGuess;
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public int userGuess
        {
            get { return m_userGuess; }
        }
        public int otherGuess
        {
            get { return m_otherGuess; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var donray = new Player("Donray", 0, 0);
            var max = new Player("Max", 0, 0);
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("How many times would you like to roll");
                ConsoleKeyInfo roll = Console.ReadKey();
                Console.Write(roll.Key);
            }
        }
    }
}
