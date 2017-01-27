using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dictionary
{
    public class Student
    {
        public Student() { }
        public Student(string n)
        {
            m_name = n;
        }
        public string m_name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> dictionary = new Dictionary<string, Student>()
            {
                { "Donray", new Student("Donray") },
                //{ 2, new Student("Max") },
                //{ 3, new Student("Trent") },
                //{ 4, new Student("Rory") },
                //{ 5, new Student("Guy") },
                //{ 6, new Student("Ben") },
            };
            var list2 = new List<Student>(); ;
            foreach (Student s in list2)
            {
                dictionary.Add(s.m_name, s);
                Console.Write(s.m_name);
            }
            Console.Read();

            //int a = 0;
            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    if (s == "n")
            //        a++;
            //    if (dictionary.ContainsKey(a))
            //    {
            //        Console.WriteLine("Works its " + dictionary[a].m_name);
            //    }
            //    else
            //    {
            //        throw new Exception("Does not work");
            //    }

            //}
        }

    }
}
