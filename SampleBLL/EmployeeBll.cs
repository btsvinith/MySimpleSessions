using SampleBLL.Dto;
using SampleDAL;
using SampleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBLL
{
    public class EmployeeBll
    {
        EmployeeDal employeeDal = new EmployeeDal();

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var employees = employeeDal.GetEmployees();
            var response = employees.Select(x => ConvertToEmployeeDto(x));
            return response;
        }

        public EmployeeDto? GetEmployee(int id)
        {
            var employee = employeeDal.GetEmployees(id).FirstOrDefault();
            var response = ConvertToEmployeeDto(employee);
            return response;
        }

        public int AddEmployee(EmployeeDto employeeDto)
        {
            var employee = ConvertToEmployee(employeeDto);
            var response = employeeDal.AddEmployee(employee);
            return response;
        }

        public bool UpdateEmployee(EmployeeDto employeeDto)
        {
            var employee = ConvertToEmployee(employeeDto);
            var response = employeeDal.UpdateEmployee(employee);
            return response;
        }

        public bool DeleteEmployee(int id)
        {
            var response = employeeDal.DeleteEmployee(id);
            return response;
        }

        private Employee ConvertToEmployee(EmployeeDto employeeDto)
        {
            Employee employee = new Employee()
            {
                Id = employeeDto.Id,
                Address = employeeDto.Address,
                Gender = employeeDto.Gender,
                DOB = employeeDto.DOB,
                Name = employeeDto.FirstName + " " + employeeDto.LastName
            };
            return employee;
        }

        private EmployeeDto ConvertToEmployeeDto(Employee employee)
        {
            var employeeName = employee?.Name?.Split(' ');
            EmployeeDto employeeDto = new EmployeeDto()
            {
                Id =  employee.Id,
                Address = employee.Address,
                Gender = employee.Gender,
                DOB = employee.DOB,
                FirstName = (employeeName.Count() > 0) ? employeeName[0] : null,
                LastName = (employeeName.Count() > 1) ? employeeName[1] : null
            };
            return employeeDto;
        }
    }
}
