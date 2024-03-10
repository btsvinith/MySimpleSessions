using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class DestructorsEx
    {
        public void Exec()
        {
            Person person1 = new Person();
            Thread.Sleep(2000);
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
                person.name = "Vinith";
                person.Display();
                //person = null;
                GC.Collect();
            }
           
           


        }
    }

    public class Person


    {
        public Person()
        {
            name = "Vinith";
        }

        public string name;

        public void Display()
        {
            Console.WriteLine("Name: " + name);
        }
        // destructor
        ~Person()
        {
            
            Console.WriteLine("Destructor called.");

        }

    }
}
