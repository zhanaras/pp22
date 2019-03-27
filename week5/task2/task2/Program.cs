using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace task2
{
    public class Marks
    {
        public int m;
        public string l;

        public Marks() { }
        public Marks(int m)
        {
            this.m = m;
            l = getLetter(m);
        }

        public static string getLetter(int m)
        {
            string letter = null;
            if (m>=0 && m <= 49)
            {
                letter = "F";
            }
            else if (m >= 50 && m <= 54)
            {
                letter = "D";
            }
            else if (m >= 55 && m <= 59)
            {
                letter = "D+";
            }
            else if (m >= 60 && m <= 64)
            {
                letter = "C-";
            }
            else if (m >= 65 && m <= 69)
            {
                letter = "C";
            }
            else if (m >= 70 && m <= 74)
            {
                letter = "C+";
            }
            else if (m >= 75 && m <= 79)
            {
                letter = "B-";
            }
            else if (m >= 80 && m <= 84)
            {
                letter = "B";
            }
            else if (m >= 85 && m <= 89)
            {
                letter = "B+";
            }
            else if (m >= 90 && m <= 94)
            {
                letter = "A-";
            }
            else if (m >= 95 && m <= 100)
            {
                letter = "A";
            }
            return letter;
        }

        public override string ToString()
        {
            return m + " " + getLetter(m);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Marks> Marks = new List<Marks>
            {
                new Marks(98),
                new Marks(54),
                new Marks(75),
            };

            FileStream fs = new FileStream("Marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
            xs.Serialize(fs, Marks);
            fs.Close();

            Marks = null;

            XmlSerializer xs2 = new XmlSerializer(typeof(List<Marks>));
            FileStream fs2 = File.OpenRead("Marks.xml");
            Marks = (List<Marks>)xs2.Deserialize(fs2);

            foreach (Marks m in Marks)
            {
                Console.WriteLine(m.ToString());
            }
            Console.ReadKey();
        }
    }
}
