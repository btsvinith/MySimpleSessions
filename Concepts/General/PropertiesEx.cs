using SimpleSessions.Models;
using Utility;

namespace SimpleSessions.Concepts.General
{
    internal class PropertiesEx : AgeCalculator
    {
        public void Exec()
        {
            ScenarioOne();
            Console.Read();
        }

        private void ScenarioOne()
        {
            Employee employeeVinith = new Employee();
            employeeVinith.Id = 1;
            employeeVinith.Name = "Vinith";
            employeeVinith.DOB = new DateTime(2001, 10, 26);
            employeeVinith.Address = "Karur";
            Employee employeeVishnu = new Employee() { Id = 2, Name = "Vishnu", DOB = new DateTime(2001, 03, 10), Address = "Chennai" };
            Employee employeeVivek = new Employee() { Id = 3, Name = "Vivek", DOB = new DateTime(1986, 06, 19), Address = "Trichy" };
            List<Employee> myEmployeeList = new List<Employee>() { employeeVinith, employeeVishnu, employeeVivek };


            Console.WriteLine("myEmployeeList[1].Address --> " + myEmployeeList[1].Address);
            Console.WriteLine("employeeVishnu.Address --> " + employeeVishnu.Address);
            employeeVishnu.Address = "Chengalpattu";
            Console.WriteLine("myEmployeeList[1].Address --> " + myEmployeeList[1].Address);
            Console.WriteLine("employeeVishnu.Address --> " + employeeVishnu.Address);
            myEmployeeList[1].Address = "Chennai";
            Console.WriteLine("myEmployeeList[1].Address --> " + myEmployeeList[1].Address);
            Console.WriteLine("employeeVishnu.Address --> " + employeeVishnu.Address);
            /*----------------------------------------------------------------------------------------------------------------------------------*/

            SetAge(myEmployeeList);

            //PrintDetails(myEmployeeList);
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
            AgeCalculator ageCalculator = new AgeCalculator();
            //TODO: Tomorrow convert this to foreach
            for (int i = 0; i < employees.Count; i++)
            {
                Employee employee = employees[i];
                // employee.Age = ageCalculator.GetAge(employee.DOB);
                //employee.Age = GetAgeProtected(employee.DOB);
                employee.Age = GetAgeProtectedInternal(employee.DOB);
                //employee.Age = ageCalculator.GetAgeProtectedInternal(employee.DOB);
            }
        }
    }
}
