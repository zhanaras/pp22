using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace polindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\pp22\week2\polindrome\input.txt");
            string word = sr.ReadLine();
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
