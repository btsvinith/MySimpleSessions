using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class MyConsole
    {
        /// <summary>
        /// Print the values one by one in the given order. List Generic
        /// </summary>
        /// <typeparam name="T">T stands for Generic type</typeparam>
        /// <param name="values">some list of values</param>
        public static void PrintValues<T>(List<T> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                //T value = values[i];
                //Console.WriteLine(value);
                Print(values[i]);
            }
        }

        /// <summary>
        /// Print the values one by one in the given order. Array Generic
        /// </summary>
        /// <typeparam name="T">T stands for Generic type</typeparam>
        /// <param name="values">some array of values</param>
        public static void PrintValues<T>(T[] values)
        {
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Print(values[i]);
            //}
            foreach (var value in values)
            {
                Print(value);
            }
        }

        private static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }


    }
}
