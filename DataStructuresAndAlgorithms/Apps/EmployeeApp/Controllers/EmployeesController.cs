using EmployeeApp.Models;
using EmployeeApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public EmployeesController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Employees);
        }

        [HttpGet("{id:int}", Name ="Get")]
        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var emp = _context.Employees.Single(e => e.Id.Equals(id));

            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
            return CreatedAtRoute("Get", new { id = emp.Id,}, emp);
            
        }

        
        [HttpPut("{id:int}")]
        public IActionResult UpdateEmployee(int id, Employee updatedEmp)
        {
            if (id != updatedEmp.Id)
            {
                return BadRequest();
            }

            var emp = _context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            emp.FirstName = updatedEmp.FirstName;
            emp.LastName = updatedEmp.LastName;
            emp.Salary = updatedEmp.Salary;
            emp.Title = updatedEmp.Title;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = _context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
