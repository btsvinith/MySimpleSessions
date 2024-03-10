using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    //TODO: Object and Dynamic Difference
    //TODO: Add comments to Var and ref examples.
    //TODO: Boxing and Unboxing
    //TODO: Overriding
    //TODO: Multiple Inheritance.
    //TODO: Multilevel Overriding, How can we stop the multilevel overriding. hint : (Sealed)
    //TODO: Interface
    //TODO: List, Array, Dictionary, Enumerable, ArrayList
    //TODO: Foreach and forloop difference
    //TODO: Linq
    //TODO: Reflection

    public class VarAndDynamicDiff
    {
        public void Exec()
        {
            VarKeywordExamples();
            Console.WriteLine("------------------------------");
            DynamicKeywordExamples();
            Console.WriteLine("------------------------------");
            ObjectKeywordExamples();
        }
        private void VarKeywordExamples()
        {
            //Var indicates that the type of the variable has to be set to the compile-time type of the initializer
            var xyz = "some Name";
            Console.WriteLine(xyz);
            xyz = "Vinith";
            Console.WriteLine(xyz);
            // xyz = 3;
            var zyx = new EmployeeCollection() { Id = 3, Name = "Vishnu" };
            Console.WriteLine(zyx.Name);

        }
        private void DynamicKeywordExamples()
        {
            //The compiler does not check the type of the dynamic type variable at compile time, instead of this, the compiler gets the type at the run time.
            dynamic xyz = "some Name";
            Console.WriteLine(xyz);
            xyz = "Vinith";
            Console.WriteLine(xyz);
            xyz = 3;
            Console.WriteLine(xyz);
            xyz = 5.55f;
            Console.WriteLine(xyz);
            xyz = new EmployeeCollection() { Id = 3, Name = "Vishnu" };
            Console.WriteLine(xyz.Name);
        }

        private void ObjectKeywordExamples()
        {
            object xyz = "some Name";
            Console.WriteLine(xyz);
            xyz = "Vinith";
            Console.WriteLine(xyz);
            xyz = 3;
            Console.WriteLine(xyz);
            xyz = 5.55f;
            Console.WriteLine(xyz);
            //object name = new EmployeeCollection() { Id = 3, Name = "Vishnu" };
            //Console.WriteLine(name.Name);

            //object zyx = new Emp() { Id = 3, Name = "Vishnu" };
            //Console.WriteLine(zyx.Name);
        }

        private void VarExamples()
        {
            // Creating and initializing
            // implicitly typed variables
            // Using var keyword
            var a = 'f';
            var b = "GeeksforGeeks";
            var c = 30.67d;
            var d = false;
            var e = 54544;

            // Display the type
            Console.WriteLine("Type of var 'a' is : {0} ", a.GetType());
                                       
            Console.WriteLine("Type of var 'b' is : {0} ", b.GetType());
                                       
            Console.WriteLine("Type of var 'c' is : {0} ", c.GetType());
                                       
            Console.WriteLine("Type of var 'd' is : {0} ", d.GetType());
                                       
            Console.WriteLine("Type of var 'e' is : {0} ", e.GetType());
        }

        private void DynamicExamples()
        {
            // Dynamic variables
            dynamic a = 'f';
            dynamic b = "GeeksforGeeks";
            dynamic c = 30.67d;
            dynamic d = false;
            dynamic e = 54544;

            // Get the actual type of
            // dynamic variables
            // Using GetType() method
            Console.WriteLine("Type of dynamic 'a' is : {0} ", a.GetType());
                                        
            Console.WriteLine("Type of dynamic 'b' is : {0} ", b.GetType());
                                        
            Console.WriteLine("Type of dynamic 'c' is : {0} ", c.GetType());
                                        
            Console.WriteLine("Type of dynamic 'd' is : {0} ", d.GetType());
                                        
            Console.WriteLine("Type of dynamic 'e' is : {0} ", e.GetType());
        }

    }

    class EmployeeCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
