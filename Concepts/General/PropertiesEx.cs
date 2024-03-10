using Concepts.Models;
using Utility;

namespace Concepts.General
{
    public class PropertiesEx : Author
    {
        public void Exec()
        {
            ScenarioTwo();
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

            PrintDetails(myEmployeeList);
        }
        private void ScenarioTwo()
        {
            Author author = new Author();
            author.Name = "Vinith";
            //author.Price = 50;
            Price = 50;
            author.DOB = new DateTime(2001, 10, 26);
            Console.WriteLine($"{author.Greeting} {Name}. Your Age is : " + author.Age);
        }

        public void PrintDetails(List<Employee> employees)
        {
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    Employee employee = employees[i];
            //    string displayText = string.Format("{0} {1} {2} {3}.", employee.Name, employee.Id, employee.Address, employee.Age);
            //    Console.WriteLine(displayText);
            //}

            foreach (Employee employee in employees)
            {
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
                employee.Age = new AgeCalculator().GetAge(employee.DOB);
                //employee.Age = ageCalculator.GetAgeProtectedInternal(employee.DOB);
            }
        }
    }
    public class Author
    {
        //<access_modifier> <return_type> <property_name>
        private DateTime dob;
        public string Name { get; set; } = "Mahesh Chand";
        public string Book { get; private set; } = "C# Programming";
        public double Price { get; protected set; } = 45.95;
        public DateTime DOB
        {
            get { return dob; }
            set
            {
                Age = new AgeCalculator().GetAge(value);
                dob = value;
            }
        }
        public string Greeting { get; private set; } = GreetingMessage();
        public int Age { get; private set; }

        //TODO : Explain why this method has to be static, later.
        //Property or field cannot access the non static members. or else refer through new Author().GreetingMessage
        public static string GreetingMessage()
        {

            DateTime Greeting = DateTime.Now;
            string greetingMessage;

            if (Greeting.Hour >= 5 && Greeting.Hour < 12)
            {
                greetingMessage = "Good morning....!";
            }
            else if (Greeting.Hour >= 12 && Greeting.Hour < 16)
            {
                greetingMessage = "Good afternoon...!";
            }
            else if (Greeting.Hour >= 16 && Greeting.Hour < 20)
            {
                greetingMessage = "Good evening...!";
            }
            else
            {
                greetingMessage = "Good night...!";
            }
            return greetingMessage;
        }
    }
}
