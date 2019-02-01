using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        //private because we don't use them anywhere else
        //the other part of the code can't affect that variables w/out necessery commands
        private string name;
        private string id;
        private int year;

        //changing the data
        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year + 1;
        }
        public string result
        {
            get
                //getting access to the private data
            {
                return name + id + year;
            }
        } 
        //И всё, shine bright like a diamond
        public static void Main()
        {
            Student s1 = new Student("Rihanna", " 18B(a)DgalRiri ", 1);
            Console.WriteLine(s1.result);
            Console.ReadKey();
        }
    }
}
