using SimpleSessions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.General
{
    internal class PropertiesEx
    {
        public void Exec()
        {
            Employee employeeVinith = new Employee();
            employeeVinith.Id = 1;
            employeeVinith.Name = "Vinith";
            employeeVinith.DOB = new DateTime(2001, 10, 26);
            employeeVinith.Address = "Karur";
            Employee employeeVishnu = new Employee() { Id = 2, Name = "Vishnu", DOB = new DateTime(2001, 03, 10), Address = "Chennai" };
            Employee employeeVivek = new Employee() { Id = 3, Name = "Vivek", DOB = new DateTime(1986, 06, 19), Address = "Trichy" };
            List<Employee> myEmployeeList = new List<Employee>() { employeeVinith, employeeVishnu, employeeVivek };

            SetAge(myEmployeeList);

            PrintDetails(myEmployeeList);
            Console.Read();
        }

        public void PrintDetails(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                string displayText = string.Format("{0} {1} {2} {3}.", employee.Name, employee.Id, employee.Address, employee.Age);
                Console.WriteLine(displayText);
            }
        }

        public void SetAge(List<Employee> employees)
        {
            //TODO: Tomorrow convert this to foreach
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                employee.Age = Age(employee.DOB);
            }
        }

        //TODO: Explain about default parameter.
        public int Age(DateTime dob, DateTime? currentDate = null)
        {
            DateTime toDate = currentDate ?? DateTime.Now;

            int dobYear = dob.Year;
            int dobMonth = dob.Month;
            int dobDay = dob.Day;

            int toDateYear = toDate.Year;
            int toMonth = toDate.Month;
            int toDay = toDate.Day;

            int age = toDateYear - dobYear;
            if (toMonth < dobMonth)
            {
                age = age - 1;
            }
            if (toMonth == dobMonth && toDay > dobDay)
            {
                age = age - 1;
            }
            return age;
        }
    }
}
