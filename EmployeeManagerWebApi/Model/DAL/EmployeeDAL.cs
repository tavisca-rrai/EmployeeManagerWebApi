using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model.DAL
{
    public class EmployeeDAL
    {
        public EmployeeDAL(string id, string name, int age, double salary, EmployeeType type)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
            Type = type;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }
        public EmployeeType Type { get; set; }
    }
}
