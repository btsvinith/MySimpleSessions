using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    public class OverridingEx
    {
        public void Exec()
        {
            BaseClass obj1 = new SubClass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }

    //Base class is Parent Class.
    class BaseClass
    {
        //Virtual Keyword: It tells the compiler that this method can be overridden by derived classes.
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }

    //SubClass is nothing but Derived/Child Class.
    class SubClass : BaseClass
    {
        //Override Keyword: In the subclass, it tells the compiler that this method is overriding the same named method in the base class.
        public override void Greetings()
        {
            //Base Keyword: In the subclass, it calls the base class method for overriding functionality.
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }

        //new Keyword: In the subclass, it tells the compiler that this method is new and independent method for the SubClass.
        //public new void Greetings()
        //{
        //    //Base Keyword: In the subclass, it calls the base class method for overriding functionality.
        //    base.Greetings();
        //    Console.WriteLine("subClass Saying Hello!");
        //}
    }
}
