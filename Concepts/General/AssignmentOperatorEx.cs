using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.General
{
    internal class AssignmentOperatorEx
    {
        //https://dotnettutorials.net/lesson/stack-and-heap-dotnet/#:~:text=Lifespan%3A%20Variables%20stored%20in%20the,themselves%2C%20not%20the%20objects).
        //https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet
        //Take image from below reference.
        // https://www.c-sharpcorner.com/article/stack-heap-value-type-and-reference-type-in-c-sharp/
        public void Exec()
        {
            int x = 10;
            x = 15;
            //recent/exising OldValue +, - , *, /, % NewValue(right side to assignment operator)
            x %= 5;

            decimal y = 10;
            float z = 10.10f;

            DateTime dob = new DateTime(2001, 10, 26);

            string name = "\"Dhoni\"";

            Console.WriteLine(name);
        }
    }
}
