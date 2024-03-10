using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class RefAndOutEx
    {
        public void Exec()
        {
            RefTypeExample();
            OutTypeExample();
        }

        private void RefTypeExample()
        {
            //Declaration + Initialization is must, before calling a ref param method.
            int i = 0;
            // Call the method with a ref parameter
            ModifyValueRef(ref i);

            // Print the modified value
            Console.WriteLine("Current ref value of integer i:" + i);
        }

        static void ModifyValueRef(ref int id)
        {
            //assignment to ref param is optional(not mandatory), inside the method
            id = 2;
        }

        private void OutTypeExample()
        {
            //Declaration is enough, before calling a out param method.
            int i;
            // Call the method with a out parameter
            GetNextNameByOut(out i);
            Console.WriteLine("Current out value of integer i:" + i);
        }

        public void GetNextNameByOut(out int id)
        {
            //assignment to out param is must(mandatory), inside the method
            id = 5;
        }
    }
}
