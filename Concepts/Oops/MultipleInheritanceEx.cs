using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Oops
{

    //Base class access should be same as derived access
    // Derived Public --> Base has to be Public
    // Derived Internal --> Base has to be Internal Only.
    // Because Derived Public will be accessable to other accemblies. So, Base cannot be with Internal restrictions.
    public class MultipleInheritanceEx 
    {
        public void Exec()
        {
            IMan employee = new Employee();
            employee.Print();
            //employee.Human();
            employee.Man();
            employee.Color();
            Console.ReadLine();
        }
    }
    interface IHuman
    {
        void Human();
        void Print();
        //Contract for Body color or rays
        void Color();

    }

    //Interface Keyword.
    //Interface can have only declaration of the methods.The method implementation will be there in dervied classes.
    //Member field can not be declared.
    //By default, Access modifiers is public.
    //Multiple inheritance is possible.
    //Object cannot be created.
    //Interface cannot have constructor.
    interface IMan
    {
        void Man();
        void Print();
        //Contract for Hair color
        void Color();
    }
    public class Employee : IMan, IHuman
    {

        public void Human()
        {
            string Name = "Vinith";
            Console.WriteLine("Name - " + Name);
        }

        public void Man()
        {
            int Age = 22;
            Console.WriteLine("Age - " + Age);
        }

        public void Print()
        {
            string Name = "Sometthing";
            Console.WriteLine("Name - " + Name);
        }

        void IHuman.Color()
        {
            Console.WriteLine("Black color Human");
        }

        void IMan.Color()
        {
            Console.WriteLine("Man's hair color is brown");
        }


    }

}
