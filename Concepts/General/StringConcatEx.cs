using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    // https://www.c-sharpcorner.com/article/6-effective-ways-to-concatenate-strings-in-c-sharp-and-net-core/
    public class StringConcatEx
    {
        public void Exec()
        {
            ScenarioFour();

        }
       
        private void ScenarioOne()
        {
            // Concatenate String Using + Operator.
            string firstName = "Vinith";
            string lastName = "Vivi";
            string name = firstName + " " + lastName;
            Console.WriteLine(name);

            Console.WriteLine("Hello" + " " + "String " + "!");
        }

        private void ScenarioTwo()
        {
            //String Interpolation.
            string author = "Mahesh Chand";
            string book = "C# Programming";

            string bookAuthor = $"{author} is the author of {book}.";
            Console.WriteLine(bookAuthor);
        }
        private void ScenarioThree()
        {
            //Concatenate string using String.
            string firstName = "Vinith";
            string secondName = "Vijay";
            string Name = string.Concat(firstName + " " + secondName);
            Console.WriteLine(Name);

            string name = string.Concat(string.Concat(firstName + " " + secondName) + " " + "Dhoni.");
            Console.WriteLine(name);

            string[] arrayStr = { "Vinith ", "Pardeep ", "Gill ", "Sumit " };
            string myString = string.Concat(arrayStr);
            Console.WriteLine(myString);

            string strArrStr = string.Concat("Authors: ", myString);
            Console.WriteLine(strArrStr);
        }

        private void ScenarioFour()
        {
            int[] intArray = { 1, 3, 5, 7, 9 };
            String seperator = ", ";
            string result = "Int, ";
            result += String.Join(seperator, intArray);
            Console.WriteLine($"Result: {result}");

            String[] arr = { "Mahesh Chand ", "Chris Love ", "Dave McCarter ", "Praveen Kumar " };
            String seperator2 = ", ";
            string response = "First Author, ";
            response += String.Join(seperator2, arr, 1, 2);
            Console.WriteLine($"Result: {response}");
        }

    }
   


}
