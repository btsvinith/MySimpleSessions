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
