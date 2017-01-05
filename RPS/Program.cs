using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Random rand = new Random();
                int pcChoice = rand.Next(1, 4);
                Console.WriteLine("Press 1 for Rock, 2 for Paper, and 3 for Scissor");
                ConsoleKeyInfo userChoice = Console.ReadKey();
                Console.Write(userChoice.Key);
                Console.Clear();
                Console.WriteLine("Press 1 for Rock, 2 for Paper, and 3 for Scissor");
                Console.WriteLine("\n");
                if (userChoice.Key.ToString() == "D1")
                {
                    Console.Write("User Choice: Rock \n");
                    if (pcChoice == 1)
                    {
                        Console.Write("Pc Choice: Rock\n");
                        Console.WriteLine("Tie");
                    }
                    else if (pcChoice == 2)
                    {
                        Console.Write("Pc Choice: Paper\n");
                        Console.WriteLine("You Lose");
                    }
                    else if (pcChoice == 3)
                    {
                        Console.Write("Pc Choice: Scissor\n");
                        Console.WriteLine("You WIN");
                    }
                }
                if (userChoice.Key.ToString() == "D2")
                {
                    Console.Write("User Choice: Paper \n");
                    if (pcChoice == 1)
                    {
                        Console.Write("Pc Choice: Rock\n");
                        Console.WriteLine("You WIN");
                    }
                    else if (pcChoice == 2)
                    {
                        Console.Write("Pc Choice: Paper\n");
                        Console.WriteLine("Tie");
                    }
                    else if (pcChoice == 3)
                    {
                        Console.Write("Pc Choice: Scissor\n");
                        Console.WriteLine("You Lose");
                    }
                }
                if (userChoice.Key.ToString() == "D3")
                {
                    Console.Write("User Choice: Scissor\n");
                    if (pcChoice == 1)
                    {
                        Console.Write("Pc Choice: Rock\n");
                        Console.WriteLine("You Lose");
                    }
                    else if (pcChoice == 2)
                    {
                        Console.Write("Pc Choice: Paper\n");
                        Console.WriteLine("You Win");
                    }
                    else if (pcChoice == 3)
                    {
                        Console.Write("Pc Choice: Scissor\n");
                        Console.WriteLine("Tie");
                    }
                }
                Console.WriteLine("\nPress Q to Quit");
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
