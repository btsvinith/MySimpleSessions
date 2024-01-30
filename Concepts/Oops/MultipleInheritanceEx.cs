using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.Oops
{
    internal class MultipleInheritanceEx
    {
        public void Exec()
        {
            
            Console.ReadLine();


        }

         class Human
        {
            public string Name;

        }
        class Man : Human
        {
            public int Age;
        }
        class Employee : Man
        {

            public int salary;

            public void getdisplay()
            {

                Console.WriteLine("Emp Name: " + Name);
                Console.WriteLine("Emp Age: " + Age);
                Console.WriteLine("Emp salary: " + salary);
            }
        }
    }
}
