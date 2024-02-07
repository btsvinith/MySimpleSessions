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
            // HeapAndStackMemoryManagements();
            ScenarioThree();
            Console.Read();
        }

        public void ScenarioOne()
        {
            MyInt x = new MyInt();
            Console.WriteLine("x.MyValue 0 - " + x.MyValue);//0
            x.MyValue = 3;
            Console.WriteLine("x.MyValue 1 - "+ x.MyValue);//3
            MyInt y;
            y = x;
            Console.WriteLine("y.MyValue 1 - " + y.MyValue);//3
            y.MyValue = 4;

            MyInt z = new MyInt();
            Console.WriteLine("x.MyValue 2.0 - " + z.MyValue);//0
            z.MyValue = 8;
            Console.WriteLine("x.MyValue 2 - " + x.MyValue);//4
            Console.WriteLine("y.MyValue 2 - " + y.MyValue);//4
            Console.WriteLine("x.MyValue 2 - " + z.MyValue);//8
            
            Console.Read();
        }

        public void ScenarioTwo()
        {
            MyInt x = new MyInt();
            Console.WriteLine("x.MyValue 0 - " + x.MyValue);//0
            x.MyValue = 3;
            Console.WriteLine("x.MyValue 1 - " + x.MyValue);//3
            MyInt y;
            y = x;
            Console.WriteLine("y.MyValue 1 - " + y.MyValue);//3
            y.MyValue = 4;

            MyInt z = new MyInt();
            MyInt m = z;
            z.MyValue = 9;
            Console.WriteLine("x.MyValue 2 - " + x.MyValue);//4
            Console.WriteLine("y.MyValue 2 - " + y.MyValue);//4
            Console.WriteLine("z.MyValue 2 - " + z.MyValue);//9
            Console.WriteLine("m.MyValue 2 - " + m.MyValue);//9
            z = x;
            Console.WriteLine("x.MyValue 2.1 - " + z.MyValue);//4
            z.MyValue = 8;
            Console.WriteLine("x.MyValue 2 - " + x.MyValue);//8
            Console.WriteLine("y.MyValue 2 - " + y.MyValue);//8
            Console.WriteLine("z.MyValue 2 - " + z.MyValue);//8
            Console.WriteLine("m.MyValue 2 - " + m.MyValue);//9

            Console.Read();
        }

        public void ScenarioThree()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y;
            y = x;
            y.MyValue = 4;
            MyInt z = new MyInt();
            MyInt m = z;
            m.MyValue = 9;
            Console.WriteLine("x.MyValue 2 - " + x.MyValue);//4
            Console.WriteLine("y.MyValue 2 - " + y.MyValue);//4
            Console.WriteLine("z.MyValue 2 - " + z.MyValue);//9
            Console.WriteLine("m.MyValue 2 - " + m.MyValue);//9
            m = x;
            Console.WriteLine("x.MyValue 2.1 - " + m.MyValue);//4
            m.MyValue = 8;
            Console.WriteLine("x.MyValue 2 - " + x.MyValue);//8
            Console.WriteLine("y.MyValue 2 - " + y.MyValue);//8
            Console.WriteLine("z.MyValue 2 - " + z.MyValue);//9
            Console.WriteLine("m.MyValue 2 - " + m.MyValue);//8

            Console.Read();
        }

        //https://medium.com/@CodeWithHonor/c-stack-vs-heap-memory-f8a737af9919
        public void HeapAndStackMemoryManagements()
        {
            int x = 5; // x is a local variable and is stored on the stack

            // y is a reference(pointer) to an object and is stored on the stack
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

    public class MyInt
    {
        public MyInt()
        { 
            MyValue = 1;
            YourValue = 1;
        
        }

        public int MyValue;
        public int YourValue;
    }


}
