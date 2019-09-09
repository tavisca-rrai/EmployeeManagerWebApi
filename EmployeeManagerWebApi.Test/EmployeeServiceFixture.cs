using EmployeeManagementSystem.Services;
using System;
using Xunit;
using EmployeeManagementSystem.Model.DAL;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Test
{
    public class EmployeeServiceFixture
    {
        EmployeeService service = new EmployeeService();
        [Fact]
        public void Employee_service_should_get_employee_by_id()
        {
            var emp = service.GetEmployee("1");
            Assert.Equal("1", emp.Record.Id);
        }
        [Fact]
        public void Employee_service_should_get_All_employee()
        {
            var employees = service.GetAllEmployee();
            Assert.NotNull(employees);
        }
        [Fact]
        public void Employee_service_should_add_employee()
        {
            var emp = new Manager(new EmployeeDAL("4", "Aniket", 23, 123123, EmployeeType.MANAGER));
            service.AddEmployee(emp);
            var employees = service.GetAllEmployee();
            Assert.Contains<Employee>(emp, employees);
        }
        [Fact]
        public void Employee_service_should_update_employee_by_id()
        {
            var emp = new GeneralEmployee(new EmployeeDAL("3", "Sundesh", 23, 123123, EmployeeType.GENERAL_EMPLOYEE));
            service.UpdateEmployee("3", emp);
            var newEmp = service.GetEmployee("3");
            Assert.Equal("Sundesh", newEmp.Record.Name);
        }
        [Fact]
        public void Employee_service_should_delete_employee_by_id()
        {
            service.DeleteEmployee("2");
            Assert.DoesNotContain<Employee>(service.GetEmployee("2"), service.GetAllEmployee());
        }
    }
}
