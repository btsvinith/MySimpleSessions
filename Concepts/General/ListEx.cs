using Common;
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
            // List<DataType> variableName = initialize the object.
            //List is a class. To initialize a class, we have to use the new keyword.
            //Use contructor to create a list object. with the help of new keyword.

            ScenarioTwo();
        }

        //Better Approach
        private void ScenarioTwo()
        {
            //integer sorting
            List<int> myIntList = new List<int>() { 5, 4, 2, 3, 1, 7, 6 };
            ArrangeAndPrint(myIntList, false);
            ArrangeAndPrint(myIntList,true);

            //float sorting
            List<float> myFloatList = new List<float>() { 5.15F, 4.21F, 2.31F, 3.22F, 1.43F, 7.55F, 6.65F };
            ArrangeAndPrint(myFloatList,true);

            //string sorting
            List<string> myStringList = new List<string>() { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            ArrangeAndPrint(myStringList, true);
        }
        private void ArrangeAndPrint<T>(List<T> values, bool isAsc)
        {
            Sorting sorting = new Sorting();
            var result = sorting.ArrangeValues(values, isAsc);
            MyConsole.PrintValues(result.ToList());
            Console.WriteLine("-------------------------------------------");
        }

        private void ArrangeAndPrint<T>(List<T> values)
        {
            Sorting sorting = new Sorting();
            var arrangeAsc = sorting.ArrangeValues(values, true);
            MyConsole.PrintValues(arrangeAsc.ToList());
            Console.WriteLine("-------------------------------------------");
            var arrangeDesc = sorting.ArrangeValues(values, false);
            MyConsole.PrintValues(arrangeDesc.ToList());
            Console.WriteLine("-------------------------------------------");
        }

        private void ScenarioThree()
        {
            //integer sorting
            List<int> myIntList = new List<int>() { 5, 4, 2, 3, 1, 7, 6 };
            ArrangeAndPrint(myIntList);

            //float sorting
            List<float> myFloatList = new List<float>() { 5.15F, 4.21F, 2.31F, 3.22F, 1.43F, 7.55F, 6.65F };
            ArrangeAndPrint(myFloatList);

            //string sorting
            List<string> myStringList = new List<string>() { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            ArrangeAndPrint(myStringList);
        }

        private void ScenarioOne()
        {
            Sorting sorting = new Sorting();

            //integer sorting
            List<int> myIntList = new List<int>() { 5, 4, 2, 3, 1, 7, 6 };
            var result = sorting.ArrangeValues(myIntList, true);
            MyConsole.PrintValues(result.ToList());
            Console.WriteLine("-------------------------------------------");
            var resultDes = sorting.ArrangeValues(myIntList, false);
            MyConsole.PrintValues(resultDes.ToList());
            Console.WriteLine("-------------------------------------------");

            //float sorting
            List<float> myFloatList = new List<float>() { 5.15F, 4.21F, 2.31F, 3.22F, 1.43F, 7.55F, 6.65F };
            var myFloatAsc = sorting.ArrangeValues(myFloatList, true);
            MyConsole.PrintValues(myFloatAsc);
            Console.WriteLine("-------------------------------------------");
            var myFloatDesc = sorting.ArrangeValues(myFloatList, false);
            MyConsole.PrintValues(myFloatDesc);
            Console.WriteLine("-------------------------------------------");

            //string sorting
            List<string> myStringList = new List<string>() { "Pardeep", "Gill", "Nithesh", "Sumit", "Gurdeep", "Dhoni", "Raina", "Jai" };
            var Name = sorting.ArrangeValues(myStringList, true);
            MyConsole.PrintValues(Name);
            Console.WriteLine("-------------------------------------------");
            var name = sorting.ArrangeValues(myStringList, false);
            MyConsole.PrintValues(name);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
