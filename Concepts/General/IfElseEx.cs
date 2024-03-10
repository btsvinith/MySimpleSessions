using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class IfElseEx
    {
        public void Exec()
        {
            string name = GetDayByIfElseBlock(5);
            IfElse(20, 18);
            Console.WriteLine(name);
        }
        public void IfElse(int x, int y)
        {
            int time = x;
            if (time < y)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time > y)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

        public string GetDayByIfElseBlock(int value)
        {
            string day = string.Empty;

            if (value == 1)
            {
                day = "Monday";
            }
            else if (value == 2)
            {
                day = "Tuesday";
            }
            else if (value == 3)
            {
                day = "Wednesday";
            }
            else if (value == 4)
            {
                day = "Thursday";
            }
            else if (value == 5)
            {
                day = "Friday";
            }
            else if (value == 6)
            {
                day = "Saturday";
            }
            else if (value == 7)
            {
                day = "Sunday";
            }
            else
            {
                day = "Invalid day";
            }

            return day;
        }
    }
}
