using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace SampleBLL.Dto
{
    public class EmployeeDto
    {
        private DateTime dob;

        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

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
