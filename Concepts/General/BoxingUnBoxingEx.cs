using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    //Refer the Boxing and UnBoxing Example with Memory management examples.
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
    public class BoxingUnBoxingEx
    {
        public void Exec()
        {
            Boxing();
            UnBoxing();

        }

        private void Boxing()
        {
            int i = 123;

            // Boxing copies the value of i into object o.
            object o = i;

            // Change the value of i.
            i = 456;

            // The change in i doesn't affect the value stored in o.
            System.Console.WriteLine("The value-type value = {0}", i);
            System.Console.WriteLine("The object-type value = {0}", o);
            /* Output:
            The value-type value = 456
            The object-type value = 123
            */
        }

        private void UnBoxing()
        {
            int i = 123;      // a value type
            object o = i;     // boxing
            // Change the value of i.
            i = 456;
            int j = (int)o;   // unboxing
            System.Console.WriteLine("The value-type value = {0}", i);
            System.Console.WriteLine("The object-type boxed value = {0}", o);
            System.Console.WriteLine("The value-type unboxed value = {0}", j);
            /* Output:
           The value-type value =  456
           The object-type boxed value = 123
            The value-type unboxed value = 123
           */
            //try
            //{
            //    int k = (short)o;  // attempt to unbox

            //    System.Console.WriteLine("Unboxing OK.");
            //}
            //catch (System.InvalidCastException e)
            //{
            //    System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            //}
           
        }
    }


}
