using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    //https://www.c-sharpcorner.com/UploadFile/0c1bb2/constructors-and-its-types-in-C-Sharp/
    public class ConstructorEx
    {
        public void Exec()
        {
            Addition.d = 6;
            CopyConstructorEx();
            Console.Read();

        }

        void DefaultConstructorEx()
        {
            Console.WriteLine("DefaultConstructorEx Start...");
            Addition objOne = new Addition(); //an object is created , constructor is called
            Console.WriteLine("objOne:a " + objOne.a);
            Console.WriteLine("objOne:b " + objOne.b);
            
            Addition objTwo = new Addition();
            Console.WriteLine("objTwo:a " + objTwo.a);
            Console.WriteLine("objTwo:b " + objTwo.b);

            Console.WriteLine("DefaultConstructorEx End...");
        }

        void ParameterizedConstructorEx()
        {
            Console.WriteLine("ParameterizedConstructorEx Start...");
            Addition objOne = new Addition(5, 3); //an object is created , constructor is called
            Console.WriteLine("objOne:a " + objOne.a);
            Console.WriteLine("objOne:b " + objOne.b);

            Addition objTwo = new Addition(7, 10);
            Console.WriteLine("objTwo:a " + objTwo.a);
            Console.WriteLine("objTwo:b " + objTwo.b);
            Console.WriteLine(Addition.d);

            
            Console.WriteLine("ParameterizedConstructorEx End...");
        }

        void CopyConstructorEx()
        {
            //Console.WriteLine("CopyConstructorEx Start...");

            Addition objOne = new Addition(); //an object is created , default constructor is called
            Console.WriteLine("objOne:a " + objOne.a);
            Console.WriteLine("objOne:b " + objOne.b);
            Console.WriteLine("objOne:Type " + objOne.Type);
            objOne.Type = "Some Cons Type";//
            Console.WriteLine("objOne:Type " + objOne.Type);


            //Addition objTwo = new Addition(7, 10); //an object is created , para constructor is called
            //Console.WriteLine("objTwo:a " + objTwo.a);
            //Console.WriteLine("objTwo:b " + objTwo.b);
            ////Console.WriteLine("objTwo:Type " + objTwo.Type);
            //objTwo.Type = "Some Para Type";
            //Console.WriteLine("objTwo:Type " + objTwo.Type);

            //TODO: Reference type and Copy obj difference.
            //Addition copy = objOne;
            Addition copy = new Addition(objOne);
            Console.WriteLine("copy:Type before override " + copy.Type);
            Console.WriteLine("objOne:Type before override " + objOne.Type);
            objOne.Type = "Test Type";//

            Console.WriteLine("copy:a " + copy.a);
            Console.WriteLine("copy:b " + copy.b);
            Console.WriteLine("copy:Type after override " + copy.Type);
            Console.WriteLine("objOne:Type after override " + objOne.Type);
            Console.WriteLine("CopyConstructorEx End...");
        }
    }

    //If nothing provided in access level, in default it is a internal class.
    class Addition
    {
        public int a, b;
        //If nothing provided in access level, in default it is a private field.
        static int c;
        public static int d;                                                                                                                                                                                 

        public string Type { get; set; }

        //No parameters in constructor. So, it is a default contructor
        // initializing instances with different values is not possible.
        public Addition()
        {
            // the values are statically assigned as 100 for a and 175 for b
            a = 100;
            b = 175;
            Type = "DefaultConstructor";
            Console.WriteLine("c:" + c);
            


        }
        //A constructor with at least one parameter is called a parameterized constructor.
        //The advantage is you can initialize each instance of the class with a different value.
        public Addition(int x, int y)  // decalaring Paremetrized Constructor with in x,y parameter
        {
            // the values are dynamically assigned as x for a and y for b
            a = x;
            b = y;
            Type = "ParaConstructor";
        }

        //The constructor which creates an object by copying variables from another object is called a copy constructor.
        //The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.
        public Addition(Addition add)   // declaring Copy constructor.
        {
            a = add.a;
            b = add.b;
            Type = add.Type;
        }

        //A static constructor does not take access modifiers or any parameters.
        //A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
        //A static constructor cannot be called directly. like new Addition()
        //The user has no control over the static constructor's execution.
        static Addition()
        {
            c = 10;
          
        }

        //TODO: Will explain this later....
        //With private constructor, it is not possible for other classes to derive from this class
        //it is not possible to create an instance of this class.
        //They are usually used in classes that contain static members only.
        private Addition(int x, int y, int z)
        {
            a = x;
            b = y;
            c = z;
        }
    }

}
