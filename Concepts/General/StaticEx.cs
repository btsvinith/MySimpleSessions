using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class StaticEx
    {
        public void Exec()
        {
            Console.WriteLine(College.CollegeName);
            Console.WriteLine(College.Address);
            
            CheckStatic cs = new CheckStatic();
            cs.Print();


            Console.WriteLine(College.CollegeName);
            Console.WriteLine(College.Address);

        }
    }
    class CheckStatic
    {
        public string TestName;
        public void Print()
        {
            Console.WriteLine(College.CollegeName);
            Console.WriteLine(College.Address);
            College.CollegeName = "I am Changed College";
        }

    }
    static class College
    {
        public static string CollegeName;
        public static string Address;

        static College()
        {
            //Console.WriteLine(College.CollegeName);
            //CollegeName = "Kongunadu Engineering and Technology...i";
            //Address = "Trichy";
        }

    }
}
