using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class IfEx
    {
        public void Exec()
        {
            string name = GetDayByIfConditionOnly(5);
            Console.WriteLine(name);
        }
        public string GetDayByIfConditionOnly(int value)
        {
            string day = string.Empty;

            if (value == 1)
            {
                day = "Monday";
            }
            if (value == 2)
            {
                day = "Tuesday";
            }
            if (value == 3)
            {
                day = "Wednesday";
            }
            if (value == 4)
            {
                day = "Thursday";
            }
            if (value == 5)
            {
                day = "Friday";
            }
            if (value == 6)
            {
                day = "Saturday";
            }
            if (value == 7)
            {
                day = "Sunday";
            }
            if (value > 7)
            {
                day = "Invalid day";
            }


            return day;
        }
    }

}
