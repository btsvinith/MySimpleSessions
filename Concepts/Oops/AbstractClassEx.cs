using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Oops
{

    // https://www.programiz.com/csharp-programming/abstract-class#google_vignette
    // https://www.geeksforgeeks.org/c-sharp-abstract-classes/
    public class AbstractClassEx
    {
        public void Exec()
        {
            ScenarioThree();

        }

        //we cannot create objects of an abstract class
        private void ScenarioOne()
        {
            // try to create an object Language
            // throws an error
            // Uncomment the below code and check it to confirm
            // Language obj = new Language();
        }

        //we can create objects of an abstract class only through the derived class
        private void ScenarioTwo()
        {
            DerivedLanguage derivedLang = new DerivedLanguage();
            derivedLang.Display2();
            derivedLang.Display1();
        }

        private void ScenarioThree()
        {
            DerivedLanguage derivedLang = new DerivedLanguage();
            derivedLang.Display2();
            derivedLang.Display1();
            derivedLang.Display3();
            derivedLang.Name = "Vinith";

            Console.WriteLine(derivedLang.Name);
        }


    }

    public class DerivedLanguage : Language
    {
        public DerivedLanguage()
        {
            Console.WriteLine("DerivedLanguage Constructor");
        }
        public void Display3()
        {
            Console.WriteLine("DerivedLanguage --> Display3");
        }
        public override void Display1()
        {
            Console.WriteLine("abstract method overrided in DerivedLanguage");
        }

        // provide implementation of abstract method
        //public override string Name { get; set; }
        public override string Name
        {
            get
            {
                return "Welcome " + name;
            }
            set
            {
                name = value;
            }
        }

    }


    // create an abstract class (pure base class)
    // We use the abstract keyword to create an abstract class.
    // "An abstract class can have both abstract methods (method without body) -- 
    // -- and non-abstract methods (method with the body)"
    public abstract class Language
    {
        public Language()
        {
            Console.WriteLine("Language Constructor");
        }

        protected string? name;

        // fields and methods
        public abstract string Name { get; set; }

        // abstract method is a contract (method without body)
        public abstract void Display1();

        // non-abstract method (method with the body)
        public void Display2()
        {
            Console.WriteLine("Non abstract method");
        }
    }
}
