using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterInterfaces
{
    public interface IDamager
    {
        void DoDamage(IDamageable d);
    }
    public interface IDamageable
    {
        void TakeDamage(float f);
    }
    class Zombie : IDamageable, IDamager
    {
        public Zombie(string n, float h) 
        {
            name = n;
            health = h;
        }
        public void DoDamage(IDamageable d)
        {
            d.TakeDamage(10);
        }

        public void TakeDamage(float f)
        {
            health -= f;
        }

        public string Name { get { return name; } }
        private string name;
        public float Health { get { return health; } }
        private float health;
    }
    class Ninja : IDamageable, IDamager
    {
        public Ninja(string n, float h)
        {
            name = n;
            health = h;
        }
        public void DoDamage(IDamageable d)
        {
            d.TakeDamage(5);
        }

        public void TakeDamage(float f)
        {
            health -= f;
        }

        public string Name { get { return name; } }
        private string name;
        public float Health { get { return health; } }
        private float health;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zombie z = new Zombie("Dude", 100);
            Ninja n = new Ninja("Bruh", 200);
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Z:
                        z.DoDamage(n);
                        Console.WriteLine("Ninja Health: " + n.Health);
                        if (n.Health <= 0)
                            return;
                        break;
                    case ConsoleKey.W:
                        n.DoDamage(z);
                        Console.WriteLine("Zombie Health:" + z.Health);
                        if (z.Health <= 0)
                            return;
                        break;
                }
            }
        }
    }
}
