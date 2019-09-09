using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model.DAL;
namespace EmployeeManagementSystem.Model
{
    public abstract class Employee
    {
        public EmployeeDAL Record { get; private set; }
        public Employee(EmployeeDAL record)
        {
            Record = record;
        }
    }
}
