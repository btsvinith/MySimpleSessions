using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Models
{
    internal class Employee
    {
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

        /// <summary>
        /// 
        /// </summary>
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public string? Address { get; set; }



    }
}
