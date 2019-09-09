using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Model.DAL;
using EmployeeManagementSystem.DB;
namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        public Employee GetEmployee(string id)
        {
           return EmployeeDB.Employees.Where(x => x.Record.Id == id).ToList<Employee>().FirstOrDefault<Employee>();   
        }
        public List<Employee> GetAllEmployee()
        {
            return EmployeeDB.Employees;
        }
        public void AddEmployee(Employee employee)
        {
            EmployeeDB.Employees.Add(employee);
        }
        public void UpdateEmployee(string id, Employee employee)
        {
            DeleteEmployee(id);
            AddEmployee(employee);
        }

        public void DeleteEmployee(string id)
        {
            EmployeeDB.Employees.RemoveAt(EmployeeDB.Employees.IndexOf(GetEmployee(id)));
        }
    }
}
