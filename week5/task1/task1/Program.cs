using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace task1
{
    public class complex
    {
        public int a;
        public int b;

        public complex() { }
        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return "a: " + a + " b: " + b;

        }
        class Program
        {
            static void Main(string[] args)
            {
                //save the numbers
                List<complex> Numbers = new List<complex>
            {
                new complex(1, 2),
                new complex(3, 4),
                new complex(5, 6),
            };

                //write the data 
                FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(List<complex>));
                xs.Serialize(fs, Numbers);
                fs.Close();

                //delete the data int the list
                Numbers = null;

                //read the data from the xml file
                XmlSerializer xs2 = new XmlSerializer(typeof(List<complex>));
                FileStream fs2 = File.OpenRead("complex.xml");
                Numbers = (List<complex>)xs2.Deserialize(fs2);


                //this must show the number that we just saved in pur xml file, but it's not working idk why
                foreach (complex n in Numbers)
                {
                    Console.WriteLine(n.ToString());
                }
                Console.ReadKey();
            }
        }
    }
}