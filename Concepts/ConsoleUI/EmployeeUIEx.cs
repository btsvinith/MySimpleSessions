using Concepts.DB;
using Concepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.ConsoleUI
{
    public class EmployeeUIEx
    {
        // TODO : Check why we can't assign or give var here...
        EmployeeDal employeeDal =  new EmployeeDal();
        public void Exec()
        {
            ScenarioOne();
        }

        private void ScenarioOne()
        {
            List<Employee> employeeList = employeeDal.GetEmployees();

            while (true)
            {
                var employee = AddEmployee();

                employeeDal.AddEmployee(employee);
                //This is added only for display purpose..
                employee.Id = employeeList.Count + 1;
                employeeList.Add(employee);


                Console.WriteLine("Press '1' to continue. '0' to Exit");
                var userOption = Console.ReadLine();
                if (userOption == "0")
                {
                    break;
                }
                Console.ReadLine();
            }

            PrintEmployees(employeeList);
            Read();
        }

        private Employee AddEmployee()
        {
            Employee employee = new Employee();

            Console.Write("Name : ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter a DOB (e.g. mm/dd/yyyy) : ");
            employee.DOB = DateTime.Parse(Console.ReadLine());
            Console.Write("Address : ");
            employee.Address = Console.ReadLine();
            Console.Write("Gender : ");
            employee.Gender = Console.ReadLine();
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
