using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Oops
{
    //https://stackoverflow.com/questions/742341/difference-between-abstraction-and-encapsulation/743698#743698
    //Encapsulation: (Information hiding.) hiding data using getters and setters etc.
    //Abstraction: (Implementation hiding.) hiding implementation using abstract classes and interfaces etc.
    public class EncapsulationandAbstractionEx
    {
        public void Exec()
        {
            ScenarioOne();
        }
        private void ScenarioOne()
        {
            Person person = new Person();
            //Abstraction (Implementation hiding.)
            person.Name = "vinith";
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        //Encapsulation: (Information hiding or Logical Information hiding.)
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
