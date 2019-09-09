using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Model.DAL;
namespace EmployeeManagementSystem.DB
{
    
    public class EmployeeDB
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Manager(new EmployeeDAL("1", "Deepak", 21, 232323, EmployeeType.MANAGER)),
            new GeneralEmployee(new EmployeeDAL("2", "Rishabh", 22, 23123, EmployeeType.GENERAL_EMPLOYEE)),
            new GeneralEmployee(new EmployeeDAL("3", "Tushar", 22, 23123, EmployeeType.GENERAL_EMPLOYEE))
        };
        
    }
}
