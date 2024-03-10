using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class LinqEx
    {
        public void Exec()
        {
            ScenarioOne();
        }

        private void ScenarioOne()
        {
            int[] values = new int[] { 5, 4, 2, 3, 1,3, 7, 6 };
            int sumResult = values.Sum();
            Console.WriteLine($"Sum : {sumResult}");
            Console.WriteLine($"Average : {values.Average()}");
            Console.WriteLine($"Count : {values.Count()}");
            Console.WriteLine($"Sum : {values.Sum()}");
            //Any check if at least one element of a collection satisfies a given condition is true
            Console.WriteLine($"Any : {values.Any(x => x==7)}");
            Console.WriteLine($"All : {values.All(x => x > 0)}");


            Console.WriteLine($"Min : {values.Min()}");
            Console.WriteLine($"Max : {values.Max()}");

            Console.WriteLine($"First : {values.First()}");
            Console.WriteLine($"Last : {values.Last()}");

            //IEnumerable<int> arrangedValues = values.OrderBy(x => x);
            int[] arrangedValues = values.OrderBy(x=>x).ToArray();

            Console.WriteLine($"First of arrangedValues: {arrangedValues.First()}");
            Console.WriteLine($"Last of arrangedValues: {arrangedValues.Last()}");

            foreach (var value in values)
            {
                Console.WriteLine($"Non Distinct : {value}");
            }
            foreach (var value in values.Distinct())
            {
                Console.WriteLine($"Distinct : {value}");
            }

        }

        private void ScenarioTwo()
        {
            List<int> values = new List<int>() { 5, 4, 2, 3, 1, 7, 6 };
            int sumResult = values.Sum();
            Console.WriteLine($"Sum : {sumResult}");
            Console.WriteLine($"Average : {values.Average()}");

            Console.WriteLine($"Min : {values.Min()}");
            Console.WriteLine($"Max : {values.Max()}");

            Console.WriteLine($"First : {values.First()}");
            Console.WriteLine($"Last : {values.Last()}");

            IEnumerable<int> arrangedValues = values.OrderBy(x => x);

            Console.WriteLine($"First of arrangedValues: {arrangedValues.First()}");
            Console.WriteLine($"Last of arrangedValues: {arrangedValues.Last()}");

            foreach (var value in values)
            {
                Console.WriteLine($"Non Distinct : {value}");
            }
            foreach (var value in values.Distinct())
            {
                Console.WriteLine($"Distinct : {value}");
            }

            //Lambada expression (x => x)
            var filteredRecords = values.Where(x => x > 5);
            //foreach (var value in values.Where(x => x > 5))
            foreach (var value in filteredRecords)
            {
                Console.WriteLine($"x > 5 Filter : {value}");
            }

        }

    }
}
