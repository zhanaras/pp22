using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            //creating 2d array
            int[][] array = new int[n][];
            for (int i=1; i<=n; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
