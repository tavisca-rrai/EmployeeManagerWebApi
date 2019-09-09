using EmployeeManagementSystem.Model.DAL;

namespace EmployeeManagementSystem.Model.Factory
{
    public interface IEmployeeFactory
    {
        Employee MakeEmployee(EmployeeDAL record);
    }
}
