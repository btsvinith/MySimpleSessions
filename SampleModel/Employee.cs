using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel
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

        public DateTime DOB { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public int CityId { get; set; }

        public int DepartmentId { get; set; }



    }
}
