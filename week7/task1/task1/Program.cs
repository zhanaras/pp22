using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] t = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                t[i] = new Thread(th);
                t[i].Name = "Bill Gates " + i;
            }
            for (int i = 0; i < 3; i++)
            {
                t[i].Start();
            }

            Console.ReadKey();
        }
        static void th()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
        
        }
    }

