using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Concepts.Models
{
    public class Employee
    {
        private DateTime dob;

        /// <summary>
        /// The Employee Id.
        /// prop + double tab.
        /// </summary>
        /// AccessModifier DataType PropertyName { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// The Employee Name
        /// </summary>
        public string? Name { get; set; }

        public DateTime DOB
        {
            get { return dob; }
            set
            {
                Age = new AgeCalculator().GetAge(value);
                dob = value;
            }
        }

        public string? Gender { get; set; }
        public int Age { get; set; }

        public string? Address { get; set; }



    }
}
