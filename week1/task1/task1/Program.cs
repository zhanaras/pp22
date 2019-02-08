using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Reading a line and converting it to integer
            int n = int.Parse(Console.ReadLine()); 
            //reading the numbers and splitting them by space
            string[] numb = Console.ReadLine().Split(' '); 
            //creating a new list
            List<int> list = new List<int>(); 
            for (int i = 0; i < n; i++)
            {
                //converting the numbers to integers
                int x = int.Parse(numb[i]); 
                int ok = 1;
                // Identifying the primes
                for (int j = 2; j <= x / 2; j++) 
                {
                    if (x % j == 0)
                    {
                        ok = 0;
                        break;
                    }
                }
             // adding primes to the list
                if (ok == 1 && x > 1) 
                    list.Add(x);
            }
            //displaying the number of elements in the list w primes
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
                //displaying the primes
                Console.Write(list[i] + " "); 
            Console.ReadKey();
        }
    }
}
