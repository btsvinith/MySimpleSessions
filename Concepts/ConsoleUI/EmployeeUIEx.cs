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
        EmployeeDal employeeDal = new EmployeeDal();
        public void Exec()
        {
            GetUserOption();
        }
        private void GetUserOption()
        {
            while (true)
            {
                Console.WriteLine("Please select your option!");
                Console.WriteLine("Option 'A' for Add an Employee");
                Console.WriteLine("Option 'B' for multiple Employees");
                Console.WriteLine("Option 'C' for Display all Employees");
                Console.WriteLine("Option 'D' for Delete an Employee");
                Console.WriteLine("Option 'E' for Edit an Employee");
                Console.WriteLine("Option 'X' for Clear Console Data");
                Console.WriteLine("Option 'Z' for Exit");
                string? userSelection = Console.ReadLine();
                userSelection = userSelection?.ToUpper();

                if (userSelection == "Z")
                {
                    break;
                }
                else
                    UserSelection(userSelection);
                Console.ReadLine();
            }
        }

        private void UserSelection(string? userSelection)
        {
            if (userSelection == "A")
            {
                AddEmployee();
            }
            else if (userSelection == "B")
            {
                AddEmployees();
            }
            else if (userSelection == "C")
            {
                List<Employee> employeeList = employeeDal.GetEmployees();
                PrintEmployees(employeeList);
            }
            else if (userSelection == "D")
            {
                DeleteEmployee();
            }
            else if (userSelection == "E")
            {
                UpdateEmployee();
            }
            else if (userSelection == "X")
            {
                Console.Clear();
            }
        }

        private void ScenarioOne()
        {
            List<Employee> employeeList = employeeDal.GetEmployees();

            while (true)
            {
                var employee = GetEmployeeUI();

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
        public void DeleteEmployee()
        {
            Console.WriteLine("Please provide an employee id to Delete...");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            bool isDeleted = employeeDal.DeleteEmployee(employeeId);
            if (isDeleted)
            {
                Console.WriteLine($"Employee with Id:{employeeId} has been deleted Successfully!!");
            }

            Console.ReadLine();

        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Please provide an employee id to Update...");
            string? employeeId = Console.ReadLine();
            
            Employee employee = GetEmployeeUI();
            employee.Id = Convert.ToInt32(employeeId);

            bool isUpdated = employeeDal.UpdateEmployee(employee);
            if (isUpdated)
            {
                Console.WriteLine($"Employee :{employee.Name} details has been Updated Successfully!!");
            }
            Console.ReadLine();

        }
        public void AddEmployees()
        {
            while (true)
            {
                var employeeUI = GetEmployeeUI();
                employeeDal.AddEmployee(employeeUI);
                Console.WriteLine($"Employee {employeeUI.Name} added Successfully!!");

                Console.WriteLine("Press '1' to continue. '0' to Exit");
                var userOption = Console.ReadLine();
                if (userOption == "0")
                {
                    break;
                }
                Console.ReadLine();
            }
        }

        public void AddEmployee()
        {
            var employeeUI = GetEmployeeUI();
            employeeDal.AddEmployee(employeeUI);
            Console.WriteLine($"Employee {employeeUI.Name} added Successfully!!");
            Console.ReadLine();
        }

        private Employee GetEmployeeUI()
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
