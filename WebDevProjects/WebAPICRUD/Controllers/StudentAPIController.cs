using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPICRUD.Models;
namespace WebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly CRUDContext context;

        public StudentAPIController(CRUDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await context.Students.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var data = await context.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost()]
        public async Task<IActionResult> Index(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Index(int id, Student student)
        {
            if (id != student.Rollno)
            {
                return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var data = await context.Students.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            context.Students.Remove(data);
            await context.SaveChangesAsync();
            return Ok(data);

        }
    }
}
