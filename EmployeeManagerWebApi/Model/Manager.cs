using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model.DAL;

namespace EmployeeManagementSystem.Model
{
    public class Manager : Employee
    {
        public List<Employee> _employeeUnderManager=new List<Employee>();
        public Manager(EmployeeDAL record) : base(record)
        {
        }
        public void AddEmployeeUnderManager(List<Employee> employeeList)
        {
            _employeeUnderManager = employeeList;
        }
    }
}
