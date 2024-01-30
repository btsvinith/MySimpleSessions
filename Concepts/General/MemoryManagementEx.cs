using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.General
{
    //https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-i/
    internal class MemoryManagementEx
    {
        public void Exec()
        {
            //Value Types(Stack): bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort
            //Reference Types(Heap): class, interface, delegate, object, string
            HeapAndStackMemoryManagements();
            Console.Read();
        }

        //https://medium.com/@CodeWithHonor/c-stack-vs-heap-memory-f8a737af9919
        public void HeapAndStackMemoryManagements()
        {
            int x = 5; // x is a local variable and is stored on the stack

            // y is a reference to an object and is stored on the stack
            // the object itself is stored on the heap
            string y = new string("hello");

            // z is a reference to the same object as y
            // both y and z are stored on the stack, but the object is only stored once on the heap
            string z = y;
                                
            // the object referenced by y and z is no longer needed, so the garbage collector will deallocate the memory on the heap
            y = null;
            z = null;

        }
    }


}
