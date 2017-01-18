﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Serialization.Classes;

namespace Serialization.Classes
{
    class DataManager
    {
        public static void Serialize<T>(string filename, T data)
        {
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            if (!File.Exists(@"..\..\" + filename + ".xml"))
            {
                FileStream work = File.Create(@"..\..\" + filename + ".xml");
                work.Close();
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
}
