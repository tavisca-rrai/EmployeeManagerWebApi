using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Model.DAL;
using EmployeeManagementSystem.Model.Factory;
namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService service = new EmployeeService();
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDAL>> Get()
        {
            return service.GetAllEmployee().Select(x=>x.Record).ToList<EmployeeDAL>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<EmployeeDAL> Get(string id)
        {
            return service.GetEmployee(id).Record;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] EmployeeDAL employeeInfo)
        {
            service.AddEmployee(new EmployeeFactory().MakeEmployee(employeeInfo));
            //service.AddEmployee()
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] EmployeeDAL employeeInfo)
        {
            service.UpdateEmployee(id, new EmployeeFactory().MakeEmployee(employeeInfo));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            service.DeleteEmployee(id);
        }
    }
}