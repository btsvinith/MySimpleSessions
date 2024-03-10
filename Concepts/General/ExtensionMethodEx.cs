using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    //Method Chaining
    public class ExtensionMethodEx
    {
        public void Exec()
        {
            string[] myStringArray = new string[] { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            //myStringArray.ArrangeValues(true).ChangeCase(false).PrintValues();
            myStringArray
                .ArrangeValues(true)
                .ChangeCase(true)
                .TakeFirst()
                .Print();
        }

    }
    internal static class UtilityExtensions
    {
        public static T[] ArrangeValues<T>(this T[] values, bool isAsc)
        {
            // Creating the empty container, as the size of input parameter size
            T[] result = new T[] { };

            // Order the input array and assign it to result
            if (isAsc)
                result = values.OrderBy(x => x).ToArray();
            else
                result = values.OrderByDescending(x => x).ToArray();

            // Return the arranged numbers/values.
            return result;
        }

        /// <summary>
        /// Print the values one by one in the given order.
        /// </summary>
        /// <typeparam name="T">T stands for Generic type</typeparam>
        /// <param name="values">some list of values</param>
        public static void PrintValues<T>(this T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public static string[] ChangeCase(this string[] values, bool isCaps)
        {
            for (int i = 0; i < values.Length; i++)
            {
                //Ternary Operator --> condition ? true : false
                values[i] = isCaps? values[i].ToUpper() : values[i].ToLower();
            }
            return values;
        }

        public static string TakeFirst(this string[] values)
        {
            return values[0];
        }

        public static void Print(this string values)
        {
            Console.WriteLine(values);
        }
    }
}
