using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_JWT.Interfaces;
using WebAPI_JWT.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        public List<Employee> GetEmployees()
        {
            return _employeeService.GetEmployeeDetails();
        }



        // POST api/<EmployeesController>
        [HttpPost]
        [Authorize]
        public Employee AddEmployee([FromBody] Employee emp)
        {
            var employee = _employeeService.AddEmployee(emp);
            return employee;
        }

    }
}
