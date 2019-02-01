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
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            string s = Console.ReadLine();
            string[] arr = s.Split();
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(arr[i]);
            }
            bool prime = false;
            int cnt = 0;
            foreach (int number in array)
            {
                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        prime = false;
                    else
                        cnt++;
                    if (prime == true)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
