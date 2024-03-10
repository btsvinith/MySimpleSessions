using Concepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions
{
    internal class Test
    {
        public void Exec()
        {
            ScenarioThree();
        }

        private void ScenarioOne()
        {
            Console.WriteLine("Give any number");
            string? a = Console.ReadLine();
            Console.WriteLine(a);

            Read();
        }

        private void ScenarioTwo()
        {
            Console.WriteLine("Name");
            string? firstName = Console.ReadLine();
            string? lastName = Console.ReadLine();
            Console.WriteLine($"Welcome : {firstName} {lastName}");

            Read();
        }

        private void ScenarioThree()
        {
            List<Employee> employeeList = new List<Employee>();

            while (true)
            {
                var employee = GetEmployee();
                employee.Id = employeeList.Count + 1;
                employeeList.Add(employee);


                Console.WriteLine("Press '1' to continue. '0' to Exit");
                var userOption = Convert.ToInt32(Console.ReadLine());
                if (userOption == 0)
                {
                    break;
                }
                Console.ReadLine();
            }

            PrintEmployees(employeeList);
            Read();
        }

        private Employee GetEmployee()
        {
            Employee employee = new Employee();

            Console.Write("Name : ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter a DOB (e.g. 10/22/1987): ");
            employee.DOB = DateTime.Parse(Console.ReadLine());
            Console.Write("Address");
            employee.Address = Console.ReadLine();
            return employee;
        }

        private void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Id : {employee.Id}");
                Console.WriteLine($"Name : {employee.Name}");
                Console.WriteLine($"Age : {employee.Age}");
                Console.WriteLine($"Address : {employee.Address}");
            }
        }

        private void Read()
        {
            Console.Beep();
            Console.Read();
            Console.Clear();
        }
    }

}

