using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Random rand = new Random();
                int randNumb = rand.Next(1, 3);
                Console.WriteLine("Try and Guess my Toss! \n \n Enter 1 for heads... \n \n Enter 2 for tails...");
                Console.WriteLine("\nPress Q to Quit");
                ConsoleKeyInfo userChoice = Console.ReadKey();
                Console.Write(userChoice.Key);
                Console.Clear();
                Console.WriteLine("Try and Guess my Toss! \n \n Enter 1 for heads... \n \n Enter 2 for tails...");
                Console.WriteLine("\nPress Q to Quit\n");
                switch (randNumb)
                {
                    case 1:
                        Console.WriteLine("It's Heads! \n");
                        if (userChoice.Key.ToString() == "D1")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                            Console.WriteLine("You Lose");
                        break;
                    case 2:
                        Console.WriteLine("It's Tails! \n");
                        if (userChoice.Key.ToString() == "D2")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                            Console.WriteLine("You Lose");
                        break;
                }
                userChoice = Console.ReadKey();
                if (userChoice.Key == ConsoleKey.Q)
                    break;
            }
            Console.Clear();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Game Over");
            Console.Read();
        }
    }
}
