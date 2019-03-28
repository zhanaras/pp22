using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task2
{
    class Program
    {
        class myThread
        {
            Thread thread;



            public myThread(string name, int n)
            {
                thread = new Thread(this.func);
                thread.Name = name;
                thread.Start(n);
            }

            void func(object n)
            {
                for (int i=1; i<=(int)n; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " displays " + i);
                    Thread.Sleep(0);
                }
                Console.WriteLine(Thread.CurrentThread.Name + " finished");
            }
        }
        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1", 4);
            myThread t2 = new myThread("Thread 2", 4);
            myThread t3 = new myThread("Thread 3", 4);

            Console.Read();
        }
    }
}
