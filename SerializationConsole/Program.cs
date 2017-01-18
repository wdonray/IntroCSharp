using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace SerializationConsole
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
    class DataManager
    {
        public static void Serialize<T>(string filename, T data)
        {
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            if (!File.Exists(@"..\..\" + filename + ".xml"))
            {
                File.Create(@"..\..\" + filename + ".xml");
            }
            TextWriter writter = new StreamWriter(@"..\..\" + filename + ".xml");
            serilaizer.Serialize(writter, data);
            writter.Close();
        }
        public static T Deserialize<T>(string fileName)
        {
            T data;
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\" + fileName + ".xml");
            data = (T)serilaizer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student test = new Student("Work", 18, "Lata");
            DataManager.Serialize<Student>("File", test);
            Student delete = DataManager.Deserialize<Student>("File");
            Console.WriteLine(delete.NAME + "\n" + delete.AGE + "\n" + delete.ID);
            Console.Read();
        }
    }
}
