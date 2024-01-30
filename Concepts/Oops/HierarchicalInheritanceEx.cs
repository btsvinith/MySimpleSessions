using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.Oops
{
    //Single level inheritance
    //Acquiring (taking) the properties, fields and methods of one class into another is called inheritance.
    internal class HierarchicalInheritanceEx
    {
        public void Exec()
        {
            Dog dogObj = new Dog();

            dogObj.name = "Puppy";
            dogObj.AnimalType = "Domestic";
            dogObj.Color = "Brown";
            dogObj.EarsType = "Rose Ears";
            dogObj.Weight = 15.5f;
            dogObj.FaceType = "Round";
            dogObj.TailType = "Curve";
            dogObj.IsMale = true;
            dogObj.Display();

            var lionObj = new Lion();
            lionObj.AnimalType = "Wild";
            lionObj.Color = "Yellow";
            lionObj.EarsType = "long Ears";
            lionObj.Weight = 15.5f;
            lionObj.HasMane = true;
            lionObj.IsMale = true;
            lionObj.Display();

            Console.ReadLine();
        }


        //Base class is Parent Class.
        class Animal
        {
            // fields and methods
            public string? AnimalType { get; set; }
            public string? Color { get; set; }

            public string? EarsType { get; set; }

            public float Weight { get; set; }
            public bool IsMale { get; set; }

            public void Display()
            {
                Console.WriteLine("\n I am an Animal... ");
                Console.WriteLine("AnimalType: " + AnimalType);
                Console.WriteLine("ColorType: " + Color);
                Console.WriteLine("EarsType: " + EarsType);
                Console.WriteLine("Weight: " + Weight);
            }
        }

        // Dog is nothing but Derived/Child Class.
        // derived class of Animal
        // Dog inherits from Animal
        class Dog : Animal
        {
            // fields and methods of Animal 
            // fields and methods of Dog
            public string? FaceType { get; set; }
            public string? TailType { get; set; }
            public string? name;


            public void Display()
            {
                base.Display(); 
                Console.WriteLine("I am a Dog Category...");
                Console.WriteLine("My Name is: " + name);
                Console.WriteLine("FaceType: " + FaceType);
                Console.WriteLine("TailType: " + TailType);
            }

        }

        class Lion : Animal
        {
            // fields and methods of Animal 
            // fields and methods of Dog 
            public bool HasMane { get; set; }
            public void Display()
            {
                base.Display();
                Console.WriteLine("I am a Lion Category...");
                Console.WriteLine("HasMane: " + HasMane);
            }
        }

        //Koalas has no tail.
        //class koalas : Animal
        //{
        //    // fields and methods of Animal 
        //    // fields and methods of Dog 
        //    public void getName()
        //    {
        //        Console.WriteLine("My name is " + name);
        //    }

        //    public void getArea()
        //    {
        //        Console.WriteLine("My area is " + area);
        //    }

        //    protected void eat()
        //    {
        //        Console.WriteLine("I can eat");
        //    }
        //}
    }

}
