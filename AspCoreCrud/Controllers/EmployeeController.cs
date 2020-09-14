//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using AspCoreCrud.Data;
//using AspCoreCrud.model;
//using Microsoft.AspNetCore.Mvc;

//namespace AspCoreCrud.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmployeeController : ControllerBase
//    {
//        private readonly ApplicationDbContext _db;

//        public EmployeeController(ApplicationDbContext db)
//        {
//            _db = db;

//        }

//        //Action methods

//        [HttpGet]
//        public IActionResult GetEmployees()
//        {
//            return Ok(_db.Employees.ToList());
//        }

//        [HttpPost]
//        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
//        {
//            if (!ModelState.IsValid)
//            {
//                return new JsonResult("Error while creating new Employee!");
//            }

//            _db.Employees.Add(employee);
//            await _db.SaveChangesAsync();
//            return new JsonResult("Employee Created");

//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateEmployee([FromRoute] int id, [FromBody] Employee employee)
//        {
//            if (employee == null || id != employee.id)
//            {
//                return new JsonResult("Employee not found!");
//            }
//            else
//            {
//                _db.Employees.Update(employee);
//                await _db.SaveChangesAsync();
//                return new JsonResult("Employee Updated");
//            }
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> RemoveEmployee([FromRoute] int id)
//        {
//            var findEmployee = await _db.Employees.FindAsync(id);
//            if (findEmployee == null)
//            {
//                return NotFound();
//            }
//            else
//            {
//                _db.Employees.Remove(findEmployee);
//                await _db.SaveChangesAsync();
//                return new JsonResult("Employee removed from database");
//            }

//        }

//    }
//}
