using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            
            //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\input.txt");
            

                //Read the first line of text
                line = sr.ReadToEnd();

                int[] array = new int[line.Length];
                string[] s = line.Split();

                //Continue to read until you reach end of file
                for(int i=0; i<500500; i++)
                {
                    array[i] = int.Parse(s[i]);
                }
               
                //close the file
                sr.Close();
                Console.ReadLine();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter (@"C:\\output.txt"))

            for (int i=3; i<=(int)Math.Floor(Math.Sqrt(array[i])); i += 2)
                {
                   if(array[i] % i == 0)
                {
                        file.WriteLine(array[i]);
                }
                }


            Console.ReadKey();
        }
    }
}
