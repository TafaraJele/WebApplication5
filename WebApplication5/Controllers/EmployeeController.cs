using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeesWrite.Models;
using EmployeesWrite.Service;

namespace EmployeesWrite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeService employeeService;

        public EmployeeController(EmployeeService _employeeService)

        {
            employeeService = _employeeService;

        }
        //GET: api/Employee

        [HttpGet]
        public ActionResult<List<Employee> >GetEmployees() =>


       employeeService.GetEmployees();


        // GET: api/Employee/5
[HttpGet]
[Route("{Id}")]
        public Employee Get(Guid Id) =>
        
            employeeService.Get(Id);
                   
        

        // POST: api/Employee
        [HttpPost]
        public string Create( Employee employee)
        {
        var employee1=    employeeService.Create(employee);

            return employee1.Id.ToString();
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{Id}")]
        //public Employee Delete(Guid Id)
        //{

        //    var employee1 = employeeService.DeleteEmployee(Id);

        //    return employee1.Id.ToString();

        //}
        
    }
}
