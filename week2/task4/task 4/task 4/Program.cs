using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing somethimg to our text file
            StreamWriter sw = new StreamWriter(@"C:\Users\user\pp22\week2\task4\path\ex.txt");
            sw.Write("hi");
            sw.Close();
            string path = (@"C:\Users\user\pp22\week2\task4\path\ex.txt");
            string path1 = (@"C:\Users\user\pp22\week2\task4\path1\ex.txt");
            //copying the file
            File.Copy(path, path1);
            File.Delete(path);
            sw.Close();
            Console.ReadKey();
        }
    }
}
