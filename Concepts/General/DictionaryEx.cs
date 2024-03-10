using Concepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class DictionaryEx
    {
        //Dictionary<TKey, TValue> stores key-value pairs.
        //Comes under System.Collections.Generic namespace.
        //Implements IDictionary<TKey, TValue> interface.
        //Keys must be unique and cannot be null.
        //Values can be null or duplicate.
        public void Exec()
        {
            //Dictionary<Emplpoyee, int> dictionary = new Dictionary<Emplpoyee, int>();
            //dictionary.Add("one", 1);
            //dictionary.Add("two", 2);
            ScenarioThree();


        }

        private void ScenarioOne()
        {
            // create a dictionary <key,value>
            Dictionary<int, string> country = new Dictionary<int, string>();

            // add items to dictionary
            country.Add(1, "Brazil");
            country.Add(2, "China");
            country.Add(3, "Usa");
            // country.Add(4, "Usa");
            country.Add(4, "Usa");

            // print value having key is 3        
            Console.WriteLine("Value having key 4: " + country[4]);
        }

        private void ScenarioTwo()
        {
            // create a dictionary 
            Dictionary<string, string> student = new Dictionary<string, string>();

            // add items to dictionary
            student.Add("Name", "Susan");
            student.Add("Faculty", "History");

            // access the value having key "Name"
            Console.WriteLine(student["Name"]);

            // access the value having key "Faculty"
            Console.WriteLine(student["Faculty"]);

            // access the value with index
            Console.WriteLine(student.ElementAt(0).Value);
            // access the key with index
            Console.WriteLine(student.ElementAt(0).Key);

            Console.WriteLine(student.ElementAt(0).Key+ " : " + student.ElementAt(0).Value);
        }

        private void ScenarioThree()
        {
            // create a dictionary 
            Dictionary<string, string> student = new Dictionary<string, string>();

            // add items to dictionary
            student.Add("Name", "Susan");
            student.Add("Faculty", "History");
            student.Add("Experiance", "Ten Years");

            Console.WriteLine("-----------foreach--------------");
            foreach (var item in student)
            {
                Console.WriteLine("Key " + item.Key + " Value " + item.Value);
            }
            Console.WriteLine("-----------for loop--------------");
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine("Key " + student.ElementAt(i).Key + " Value " + student.ElementAt(i).Value);
            }
        }

        private void ScenarioFour()
        {
            // create a dictionary 
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();


            Employee employeeVinith = new Employee();
            employeeVinith.Id = 1;
            employeeVinith.Name = "Vinith";
            employeeVinith.DOB = new DateTime(2001, 10, 26);
            employeeVinith.Address = "Karur";
            Employee employeeVishnu = new Employee() { Id = 2, Name = "Vishnu", DOB = new DateTime(2001, 03, 10), Address = "Chennai" };
            Employee employeeVivek = new Employee() { Id = 3, Name = "Vivek", DOB = new DateTime(1986, 06, 19), Address = "Trichy" };
            employees.Add(1, employeeVinith);
            employees.Add(2, employeeVishnu);
            employees.Add(3, employeeVivek);


            //var employeeList = GetEmployees();
            ////add items to dictionary
            //employees.Add(1, employeeList[0]);
            //employees.Add(2, employeeList[1]);
            //employees.Add(3, employeeList[2]);

            Console.WriteLine("-----------foreach--------------");
            foreach (var item in employees)
            {
                Console.WriteLine("Key " + item.Key + " Value " + item.Value.Name);
            }
            Console.WriteLine("-----------for loop--------------");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("Key " + employees.ElementAt(i).Key + " Value " + employees.ElementAt(i).Value.DOB);
            }
        }

        private List<Employee> GetEmployees()
        {
            Employee employeeVinith = new Employee();
            employeeVinith.Id = 1;
            employeeVinith.Name = "Vinith";
            employeeVinith.DOB = new DateTime(2001, 10, 26);
            employeeVinith.Address = "Karur";
            Employee employeeVishnu = new Employee() { Id = 2, Name = "Vishnu", DOB = new DateTime(2001, 03, 10), Address = "Chennai" };
            Employee employeeVivek = new Employee() { Id = 3, Name = "Vivek", DOB = new DateTime(1986, 06, 19), Address = "Trichy" };
            List<Employee> myEmployeeList = new List<Employee>() { employeeVinith, employeeVishnu, employeeVivek };

            return myEmployeeList;
        }

    }
   
   
}
