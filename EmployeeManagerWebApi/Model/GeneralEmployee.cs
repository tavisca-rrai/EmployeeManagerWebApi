using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model.DAL;

namespace EmployeeManagementSystem.Model
{
    public class GeneralEmployee : Employee
    {
        public GeneralEmployee(EmployeeDAL record) : base(record)
        {
        }
    }
}
