using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sorting
    {

        /// <summary>
        /// Arrange the given values in asc or des.
        /// </summary>
        /// <typeparam name="T">T stands for Generic type of values</typeparam>
        /// <param name="values">some list of values</param>
        /// <param name="isAsc">true for ascending order, false for descending order</param>
        /// <returns></returns>
        public List<T> ArrangeValues<T>(List<T> values, bool isAsc)
        {
            // Creating the empty container, as the size of input parameter size
            IEnumerable<T> result = new List<T>();

            // Order the input array and assign it to result
            if (isAsc)
                result = values.OrderBy(x => x);
            else
                result = values.OrderByDescending(x => x);

            // Return the arranged numbers/values.
            return result.ToList();
        }

        /// <summary>
        /// Arrange the given values in asc or des.
        /// </summary>
        /// <typeparam name="T">T stands for Generic type of values</typeparam>
        /// <param name="values">some array of values</param>
        /// <param name="isAsc">true for ascending order, false for descending order</param>
        /// <returns>Arranged array values</returns>
        public T[] ArrangeValues<T>(T[] values, bool isAsc)
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
    }
}
