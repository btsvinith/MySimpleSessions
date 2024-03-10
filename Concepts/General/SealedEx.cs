using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Concepts.General
{
    //Sealed class cannot be inherited. Only way to access its Members is through object only.
    public class SealedEx : SealedB//: SealedA
    {
        public void Exec()
        {

            ScenarioTwo();
        }

        private void ScenarioOne()
        {
            
            Add();
        }

        private void ScenarioTwo()
        {
            SealedA sealedA = new SealedA();
            sealedA.Name = "Vinith";
            //we cannot set value for Price because it is a protected set field.
            //sealedA.Price = 50;
            sealedA.DOB = new DateTime(2001, 10, 26);
            Console.WriteLine($"{sealedA.Greeting} {sealedA.Name}. Your Age is : " + sealedA.Age);
        }
    }

    public sealed class SealedA : Author
    {
        //Inherited Author class to access all the below codes from base class.
        //private DateTime dob;
        //public string Name { get; set; } = "Mahesh Chand";
        //public string Book { get; private set; } = "C# Programming";
        //public double Price { get; protected set; } = 45.95;

        //public DateTime DOB
        //{
        //    get { return dob; }
        //    set
        //    {
        //        Age = new AgeCalculator().GetAge(value);
        //        dob = value;
        //    }
        //}
        //public string Greeting { get; private set; } = Author.GreetingMessage();
        //public int Age { get; private set; }
    }

    public  class ClassA
    {

        public virtual int Add()
        {
            int a = 10;
            int b = 5;
            return a + b;
        
        }
        
    }

    public class ClassB : ClassA
    {
        //Not mandatory to override all the virtual methods.
        //public override int Add()
        //{
        //    int a = 8;
        //    int b = 5;
        //    return a + b;

        //}

    }

    public class ClassC : ClassB
    {

        //Overriding the ClassA virtual method.
        public override int Add()
        {
            int a = 7;
            int b = 5;
            return a + b;

        }

    }

    //Members has the sealed access.
    public class ClassD : ClassC
    {

        //Overriding the ClassC overrided method, with sealed in ClassD, for no more overrides.
        public sealed override int Add()
        {
           
            int a = 5;
            int b = 5;
            return a + b;

        }

    }

    public class  SealedB: ClassD
    {
        //Due to Sealed protection, we cannot override the Add method here.
        //public override int Add()
        //{
        //    int a = 7;
        //    int b = 5;
        //    return a + b;

        //}

        public int Sub(int a, int b)
        {
            return a - b;

        }

    }

}
