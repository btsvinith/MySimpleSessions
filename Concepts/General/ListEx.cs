using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.General
{
    internal class ListEx
    {
        public void Exec()
        {
            //f-12 to see the class structure.
            //ctrl - return to same place
            // List<DataType> variableName = initialize the object.
            //List is a class. To initialize a class, we have to use the new kwy word.
            //Use contructor to create a list object. with the help of new keyword.
            List<int> myList = new List<int>() { 5, 4, 2, 3, 1, 7, 6 };
            var result = ArrangeNumbers(myList, "asc");
            PrintValues(result.ToList());

            var resultDes = ArrangeNumbers(myList, "vinith");
            PrintValues(resultDes.ToList());

            //List<float> myNum = new List<float>() { 5.15F, 4.21F, 2.31F, 3.22F, 1.43F, 7.55F, 6.65F };
            //var result = ArrangeValuesByAscending(myNum);
            //PrintValues(result);

            //var resultDes = ArrangeValues(myNum);
            //PrintValues(resultDes);



            //List<string> myStringList = new List<string>() { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            //var Name = ArrangeValues(myStringList, true);
            //PrintValues(Name);

            //List<string> MyStringList = new List<string>() { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            //var name = ArrangeValues(MyStringList, false);
            //PrintValues(name);
        }

        /// <summary>
        /// Arrange the given values in asc or des.
        /// </summary>
        /// <typeparam name="T">T stands for Generic type of values</typeparam>
        /// <param name="values">some list of values</param>
        /// <param name="isAsc">true for ascending order, false for descending order</param>
        /// <returns></returns>
        //public List<T> ArrangeValues<T>(List<T> values, bool isAsc)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    IEnumerable<T> result = new List<T>();

        //    // Order the input array and assign it to result
        //    if (isAsc)
        //        result = values.OrderBy(x => x);
        //    else
        //        result = values.OrderByDescending(x => x);

        //    // Return the arranged numbers/values.
        //    return result.ToList();
        //}

        /// <summary>
        /// Print the values one by one in the given order.
        /// </summary>
        /// <typeparam name="T">T stands for Generic type</typeparam>
        /// <param name="values">some list of values</param>
        public void PrintValues<T>(List<T> values)
        {
            IEnumerable<T> result = new List<T>();

            for (int i = 0; i < values.Count; i++)
            {
                T value = values[i];
                Console.WriteLine(value);
            }
        }


        //public List<float> ArrangeValuesByAscending(List<float> values)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    List<float> result = new List<float>();
        //    // Order the input array and assign it to result
        //    result = values.OrderBy(x => x).ToList();

        //    // Return the arranged numbers/values.
        //    return result;
        //}

        public int[] ArrangeNumbers(List<int> values, string order)
        {
            // Creating the empty container, as the size of input parameter size
            IEnumerable<int> result = new List<int>();

            // Order the input array and assign it to result
            if (order == "asc")
                result = values.OrderBy(x => x);
            else
                result = values.OrderByDescending(x => x);

            // Return the arranged numbers/values.
            return result.ToArray();
        }


        //public List<string> ArrangeValuesByAscending(List<string> values)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    List<string> result = new List<string>();
        //    // Order the input array and assign it to result
        //    result = values.OrderBy(x => x).ToList();

        //    // Return the arranged numbers/values.
        //    return result;
        //}

        //public List<string> ArrangeValuesByDescending(List<string> values)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    List<string> result = new List<string>();

        //    // Order the input array and assign it to result
        //    result = values.OrderByDescending(x => x).ToList();

        //    // Return the arranged numbers/values.
        //    return result;
        //}
    }
}
