using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.Classes;
namespace Serialization.Classes
{
    public class Student
    {
        private string m_Name;
        private int m_Age;
        private string m_ID;
        public Student() { }

        public Student(string name, int age, string id)
        {
            m_Name = name;
            m_Age = age;
            m_ID = id;
        }
        public string NAME { get { return m_Name; } set { m_Name = value; } }
        public int AGE { get { return m_Age; } set { m_Age = value; } }
        public string ID { get { return m_ID; } set { m_ID = value; } }
    }
}
