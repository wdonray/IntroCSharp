using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    class Dude
    {
        public Dude(){}
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
            Console.Write(m_name, " is currently working");
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
            var donray = new Student();
            List<Student> students = new List<Student>();
            
            for (int i = 1; i < 11; i++)
            {
                students.Add(new Student("work", "white", "N/A", i, true));

            }

            var teacher = new Dude();
            students.ForEach(x => x.Attack(teacher));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(students[i].age);
            }
            //donray.age = 19;
            //donray.m_name = "Donray";
            //donray.m_gender = "Male";
            //donray.m_race = "Black";
            //donray.m_trash = true;
            //Console.WriteLine(donray.name);
            //Console.WriteLine(donray.age);
            //Console.WriteLine(donray.gender);
            //Console.WriteLine(donray.ethnicity);
            //Console.WriteLine(donray.trash);
            Console.Read();
        }
    }
}
