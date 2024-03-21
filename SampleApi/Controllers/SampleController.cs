using Concepts.DB;
using Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        EmployeeDal employeeDal = new EmployeeDal();
        [Route("Names")]
        [HttpGet]
        public IEnumerable<string> GetNames()
        {
           List<string> names = new List<string>() { "Ram","Somu","Vijay"};
            return names;   
        }

        [Route("all")]
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            var response = employeeDal.GetEmployees();
            return response;
        }

        [Route("{id}")]
        [HttpGet]
        public Employee? GetEmployee(int id)
        {
            var response = employeeDal.GetEmployees(id).FirstOrDefault();
            return response;
        }

        [Route("add")]
        [HttpPost]
        public int AddEmployee([FromBody]Employee employee)
        {
            var response = employeeDal.AddEmployee(employee);
            return response;
        }

        [Route("update")]
        [HttpPut]
        public bool UpdateEmployee([FromBody] Employee employee)
        {
            var response = employeeDal.UpdateEmployee(employee);
            return response;
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            var response = employeeDal.DeleteEmployee(id);
            return response;
        }
    }
}
