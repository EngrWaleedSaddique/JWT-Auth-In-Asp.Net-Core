using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_JWT.Models;

namespace WebAPI_JWT.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
    }
}
