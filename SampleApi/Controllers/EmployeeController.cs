using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleBLL;
using SampleBLL.Dto;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        EmployeeBll employeeBll = new EmployeeBll();

        [Route("all")]
        [HttpGet]
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var response = employeeBll.GetEmployees();
            return response;
        }

        [Route("{id}")]
        [HttpGet]
        public EmployeeDto? GetEmployee(int id)
        {
            var response = employeeBll.GetEmployee(id);
            return response;
        }

        [Route("add")]
        [HttpPost]
        public int AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            var response = employeeBll.AddEmployee(employeeDto);
            return response;
        }

        [Route("update")]
        [HttpPut]
        public bool UpdateEmployee([FromBody] EmployeeDto employeeDto)
        {
            var response = employeeBll.UpdateEmployee(employeeDto);
            return response;
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            var response = employeeBll.DeleteEmployee(id);
            return response;
        }
    }
}
