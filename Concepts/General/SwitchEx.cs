﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class SwitchEx
    {

        public void Exec()
        {
            string name =GetDayBySwitchBlock(4);
            Console.WriteLine(name);
        }
        public string GetDayBySwitchBlock(int value)
        {
            string day;
            switch (value)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Invalid day";
                    break;
            }

            return day;
        }
    }
}
