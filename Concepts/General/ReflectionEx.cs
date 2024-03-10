
namespace Concepts.General
{
    //https://www.geeksforgeeks.org/what-is-reflection-in-c-sharp/
    //Is Reflection In C# Slow, <Yes>
    //Reflection is the process of describing the metadata of types, methods and fields in a code
    public class ReflectionEx
    {
        public void Exec()
        {
            ScenarioThree();
        }

        private void ScenarioOne()
        {
            // Using GetType to obtain type information:
            int i = 42;
            Console.WriteLine($"i value : {i}");
            Type type = i.GetType();
            Console.WriteLine($"type : {type}");
        }

        private void ScenarioTwo()
        {
            // Using GetType to obtain type information:
            string i = "Vinith";
            Console.WriteLine($"i value : {i}");
            Type type = i.GetType();
            Console.WriteLine($"type : {type}");
        }

        private void ScenarioThree()
        {
            // Initialise t as typeof string 
            Type t = typeof(string);

            // Use Reflection to find about 
            // any sort of data related to t 
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
        }

    }
}
