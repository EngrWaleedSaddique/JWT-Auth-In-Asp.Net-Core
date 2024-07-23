using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_JWT.Context;
using WebAPI_JWT.Interfaces;
using WebAPI_JWT.Models;

namespace WebAPI_JWT.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _context;
        public EmployeeService(JwtContext context) {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
