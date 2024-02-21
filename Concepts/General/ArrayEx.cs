using Common;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.General
{
    internal class ArrayEx  
    {
        public void Exec()
        {
            ScenarioOne();
        }

        private void ScenarioTwo()
        {
            //integer sorting
            int[] myIntArray = new int[] { 5, 4, 2, 3, 1, 7, 6 };
            ArrangeAndPrint(myIntArray, false);
            ArrangeAndPrint(myIntArray, true);

            //float sorting
            float[] myFloatArray = new float[] { 5.15F, 4.21F, 2.31F, 3.22F, 1.43F, 7.55F, 6.65F };
            ArrangeAndPrint(myFloatArray, true);

            //string sorting
            string[] myStringArray = new string[] { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            ArrangeAndPrint(myStringArray, true);
        }

        private void ArrangeAndPrint<T>(T[] values, bool isAsc)
        {
            Sorting sorting = new Sorting();
            var result = sorting.ArrangeValues(values, isAsc);
            MyConsole.PrintValues(result.ToList());
            Console.WriteLine("-------------------------------------------");
        }

        private void ArrangeAndPrint<T>(T[] values)
        {
            Sorting sorting = new Sorting();
            var arrangeAsc = sorting.ArrangeValues(values, true);
            MyConsole.PrintValues(arrangeAsc.ToList());
            Console.WriteLine("-------------------------------------------");
            var arrangeDesc = sorting.ArrangeValues(values, false);
            MyConsole.PrintValues(arrangeDesc.ToList());
            Console.WriteLine("-------------------------------------------");
        }

        private void ScenarioOne()
        {
            int[] myArray = { 5, 4, 2, 3, 1, 7, 6 };
            var result = ArrangeNumbers(myArray, "asc");
            PrintNumbers(result);


            var resultDes = ArrangeNumbers(myArray, "vinith");
            PrintNumbers(resultDes);
        }

        public int[] ArrangeNumbers(int[] values, string order)
        {
            // Creating the empty container, as the size of input parameter size
            int[] result = new int[values.Length];

            // Order the input array and assign it to result
            if (order == "asc")
                result = values.OrderBy(x => x).ToArray();
            else
                result = values.OrderByDescending(x => x).ToArray();

            // Return the arranged numbers/values.
            return result;
        }




        //public int[] ArrangeNumbers(int[] values, bool isAsc)
        //{
        //   // Creating the empty container, as the size of input parameter size
        //        int[] result = new int[values.Length];

        //    // Order the input array and assign it to result
        //    if (isAsc)
        //        result = values.OrderBy(x => x).ToArray();
        //    else
        //        result = values.OrderByDescending(x => x).ToArray();

        //    // Return the arranged numbers/values.
        //    return result;
        //}

        //public int[] ArrangeNumbersByAscending(int[] values)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    int[] result = new int[values.Length];

        //    // Order the input array and assign it to result
        //    result = values.OrderBy(x => x).ToArray();

        //    // Return the arranged numbers/values.
        //    return result;
        //}

        //public int[] ArrangeNumbersByDescending(int[] values)
        //{
        //    // Creating the empty container, as the size of input parameter size
        //    int[] result = new int[values.Length];

        //    // Order the input array and assign it to result
        //    result = values.OrderByDescending(x => x).ToArray();

        //    // Return the arranged numbers/values.
        //    return result;
        //}

        //public void PrintNumbers(string[] values)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        string value = values[i];
        //        Console.WriteLine(value);
        //    }

        //}

        public void PrintNumbers(int[] values)
        {
            for (int i = 0; i < 7; i++)
            {
                int value = values[i];
                Console.WriteLine(value);
            }
        }
    }
}
