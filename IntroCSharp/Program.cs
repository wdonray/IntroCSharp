using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    class Entity
    {
        public Entity() { }

        public Entity(int h, int att)
        {
            health = h;
            attackpower = att;
        }
        private int health, attackpower;
        protected int Health
        {
            get { return health; }
        }
        protected int AttackPower
        {
            get { return attackpower; }
        }
        private string name;
        public string Name
        {
            get { return name; }
        }

        public virtual bool Attack(Entity d)
        {
            d.health -= attackpower;
            return true;
        }
    }
    class Player : Entity
    {
        public Player() { }
        public Player(int h, int att) : base(h, att) { }
        public override bool Attack(Entity d)
        {
            return base. Attack(d);
        }
        public bool Defend()
        {
            return true;
        }
    }
    class Zombie : Entity
    {
        public Zombie() { }
        public Zombie(int h, int att) : base(h, att) { }
        public override bool Attack(Entity d)
        {
            return base.Attack(d);
        }

    }
    class Dude
    {
        public Dude() { }
        public void Attack(Dude d)
        {
            Console.WriteLine("attack" + d.ToString());
        }
    }
    class Student : Dude
    {
        public Student() { }
        public Student(string name, string ethnicity, string gender, int age, bool trash)
        {
            m_name = name;
            m_race = ethnicity;
            m_gender = gender;
            m_age = age;
            m_trash = trash;
        }
        public string m_name, m_race, m_gender;
        public int m_age;
        public bool m_trash;
        public void Work()
        {
            Console.Write(m_name);
            Console.WriteLine(" is currently working");
        }
        public int age
        {
            get { return m_age; }
            set { m_age = value; }
        }
        public bool trash
        {
            get { return m_trash; }
            set { m_trash = value; }
        }
        public string name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public string ethnicity
        {
            get { return m_race; }
            set { m_race = value; }
        }
        public string gender
        {
            get { return m_gender; }
            set { m_gender = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zombie z = new Zombie(10, 2);
            Player p = new Player(14, 3);
            for (int i = 0; i < 5; i++)
            {
                z.Attack(p);
            }
            Console.Read();
        }
    }
}
