using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Oops
{
    public class InterfaceEx
    {
        public void Exec()
        {
            var pig = new Pig();
            pig.AnimalSound();
            Console.ReadLine();
        }
    }
    interface IAnimal
    {
        public int Name { get; set; }
        void AnimalSound();
    }

    public class Pig : IAnimal
    {
        public int Name { get; set; }
        public void AnimalSound()
        {
            Name = 1;
            Console.WriteLine(" The Pig Say : Wee Wee ");
        }
    }
}
