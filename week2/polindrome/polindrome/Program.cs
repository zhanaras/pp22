using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            string reverse = String.Empty;
            //reversing the string
            for (int i=arr.Length -1; i>-1; i--)
            {
                reverse += arr[i];
            }
            if (reverse == word)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            Console.ReadKey();
        }
        
    }
}
