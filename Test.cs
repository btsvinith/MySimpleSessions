using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions
{
    internal class Test
    {
        public Test()
        { }

        public Test(int something)
        {
        }
        public void Add(int a, int b)
        {
            int d = a + b;
            Console.WriteLine(d);
        }
        public int Add(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }

        public string Add(string name, string fatherName, string motherName)
        {
            // string d = fatherName +" " + motherName + " "+ name  +".";
            string d = string.Format("{0} {1} {2}.", name, motherName, fatherName);
            return d;
        }

        public void PrintTable(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine(i);

            }
        }

        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;

        }
        public string Add(string a, string b)
        {
            string d = a + " " + b;
            return d;
        }
        public void Age(int Age)
        {
            int a = DateTime.Now.Year;
            int result = a - Age;
            Console.WriteLine(result);
        }


    }
}

