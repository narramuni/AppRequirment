using System.Web.Http;
using BusinessLogicLayer;
using DataAccessLayer;

namespace AppServiceLayer.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            // Initialize the service with the BLL
            _employeeService = new EmployeeService();
        }

        // GET api/employee
        [HttpGet]
        public IHttpActionResult GetEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        // GET api/employee/5
        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST api/employee
        [HttpPost]
        public IHttpActionResult PostEmployee(EmpProfile employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _employeeService.AddEmployee(employee);
            return CreatedAtRoute("DefaultApi", new { id = employee.EmpCode }, employee);
        }

        // PUT api/employee/5
        [HttpPut]
        public IHttpActionResult PutEmployee(int id, EmpProfile employee)
        {
            if (!ModelState.IsValid || id != employee.EmpCode)
            {
                return BadRequest(ModelState);
            }

            var existingEmployee = _employeeService.GetEmployeeById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            _employeeService.UpdateEmployee(employee);
            return Ok(employee);
        }

        // DELETE api/employee/5
        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployeeById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            _employeeService.DeleteEmployee(existingEmployee);
            return Ok(existingEmployee);
        }
    }
}
