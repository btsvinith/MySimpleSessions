using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.Oops
{
    internal class SingleInheritanceEx
    {
        public void Exec()
        {

            ScenarioOne();
            Console.ReadLine();
        }

        private void ScenarioOne()
        {
            Student myObj = new Student();
            //TODO: Have to find and set values for base class with same property names.
            myObj.Id = 1;
            //use casting ((Department)myObj) to get/access Department properties
            ((Department)myObj).Id = 2;
            myObj.Name = "Vinith";
            ((Department)myObj).Name = "CSE";
            myObj.NoOfLabs = 5;
            myObj.Display();
        }

        private void ScenarioTwo()
        {
            Department myObj = new Student();
            myObj.Id = 1;
            myObj.Name = "Vinith";
            myObj.NoOfLabs = 5;
        }

        class Department 
        {
            public int Id { get; set; }
            public string Name { get; set; }

           internal int NoOfLabs { get; set; }
        }

        class Student : Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public void Display()
            {

                Console.WriteLine("Student Id: " + Id);
                Console.WriteLine("Department Id: " +base.Id);
                Console.WriteLine("Student Name: " + Name);
                Console.WriteLine("Department Name: " + base.Name);
                Console.WriteLine("Department NoOfLabs: " + base.NoOfLabs);
            }
        }
    }
}
