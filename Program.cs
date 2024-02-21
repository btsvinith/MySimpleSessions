using SimpleSessions.Concepts;
using SimpleSessions.Concepts.General;
using SimpleSessions.Concepts.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions
{
    internal class Program
    {
        //f-12 to see the class structure.
        //ctrl - return to same place
        static void Main(String[] args)
        {
            //DataType variableName = DateType obj/value
            var currentObj = new RefAndOutEx();
            currentObj.Exec();

        }
    }
}
