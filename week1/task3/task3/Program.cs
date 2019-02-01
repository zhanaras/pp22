using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //defining the range of the array by user's input
            int length = Convert.ToInt32(Console.ReadLine());
            //creating an array
            int[] array = new int[length];

            //enetering the elements of the array 
            string s = Console.ReadLine();
            //spliting that elements from each other to make them separate
            string[] arr = s.Split();

            //converting that elements into integers to enter them into our array
            //also we can use int.Parse command
            for (int i=0; i<length; i++)
            {
                array[i] = Convert.ToInt32(arr[i]);
            }

            //output
            for (int i=0; i<length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
