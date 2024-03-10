using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    // https://www.c-sharpcorner.com/article/type-of-methods-in-c-sharp/
    public class MethodTypesEx
    {
        public void Exec()
        {
            //Overriding is one of the method type, please refer, OverridingEx.cs file
            //Static is one of the method type, please refer, StaticEx.cs file
            //Extension is one of the method type, please refer, ExtensionMethodEx.cs file
            //Ref and Out is one of the method {param} type, please refer, RefAndOutEx.cs file

            ScenarioOne();
        }

        //Arrow method or Lambada expression. returns a int value
        private int Add(int a, int b) => a + b;

        // It is a void method, It wont return any value(s)
        private void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }

        //Optional Parameters.
        // private string FullName(string firstName, string lastName,[Optional] string middleName)
        private string FullName(string firstName, string lastName, string middleName = "S")
        {
            //return firstName + " " + middleName + " " + lastName;
            return $"{firstName} {middleName} {lastName}";
        }

        private void ScenarioThree()
        {
            //Vinith is FirstName, Ravi is LastName
            Console.WriteLine($"Full Name is : {FullName("Vinith", "Ravi")}");
            Console.WriteLine($"Full Name is : {FullName("Ravi", "Vinith")}");

            //Named Parameter
            Console.WriteLine($"Full Name is : {FullName(lastName: "Ravi", firstName: "Vinith")}");
            // If named param position changes, then all the params has to be named. Otherwise, It throws compilation error.
            //Console.WriteLine($"Full Name is : {FullName(lastName: "Ravi", "Vinith")}");
            Console.WriteLine($"Full Name is : {FullName(firstName: "Ravi", "Vinith")}");
            Console.WriteLine($"Full Name is : {FullName("Vinith", lastName: "Ravi")}");

            //overrided the Optional Parameter "S" to "A" by passing a value to it
            Console.WriteLine($"Full Name is : {FullName("Vinith", lastName: "Ravi", "A")}");


            Console.ReadLine();
        }
        private void ScenarioOne()
        {
            Console.WriteLine("Factorial of 7 is : {0}", Factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", Factorial(8));
            Console.ReadLine();
        }

        private void ScenarioTwo()
        {
            bool hasVowel = 'r'.HasVowel();
            //var result = $"Check the Char r is vowel:{'r'.HasVowel()} : " + hasVowel;
            var result = "Check the Char r is vowel:{'r'.HasVowel()} : " + hasVowel;
            Console.WriteLine(result);
            Console.WriteLine($"Check the Char O is vowel: {'O'.HasVowel()}");

            Console.WriteLine($"'TestME' String has a vowel? : {"TestME".HasVowel()}");
            Console.WriteLine($"'JCB' String has a vowel? : {"JCB".HasVowel()}");
            Console.ReadLine();
        }
        // Recursive Method Call
        // A method can call itself. This is known as recursion.
        public int Factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }
    }
    internal static class UtilityEx
    {
        static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        //Extension Method, the first parameter has this keyword.
        public static bool HasVowel(this char someChar)
        {
            //Converting input char to lower, because we have all the vowels in lower only.
            bool result = vowels.Contains(Char.ToLower(someChar));
            return result;
        }

        //Overloading method.
        public static bool HasVowel(this string someStringVal)
        {
            bool result = false;

            foreach (char someChar in someStringVal)
            {
                if (vowels.Contains(Char.ToLower(someChar)))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }

    partial class MyClassA
    {
        partial void OnSomethingHappened(string s);
    }
    partial class MyClassA
    {
        private void Add()
        { 
        }
    }
    // This part can be in a separate file.   
    partial class MyClassA
    {
        // Comment out this method and the program   
        // will still compile.   
        partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
