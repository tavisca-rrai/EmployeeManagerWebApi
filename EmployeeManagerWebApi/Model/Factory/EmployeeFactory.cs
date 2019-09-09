using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Model.DAL;

namespace EmployeeManagementSystem.Model.Factory
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee MakeEmployee(EmployeeDAL record)
        {
            if (record.Type == EmployeeType.GENERAL_EMPLOYEE)
                return new GeneralEmployee(record);
            else if (record.Type == EmployeeType.MANAGER)
                return new Manager(record);
            else
                throw new InvalidEmployeeTypeException("Employee Type Exception");
        }
    }
}
