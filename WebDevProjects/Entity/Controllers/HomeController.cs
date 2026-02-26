using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Entity.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext context;

        public HomeController(StudentDBContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var stdData = await context.Students.ToListAsync();
            return View(stdData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (!ModelState.IsValid)
            {
                return View(std);
            }
            await context.Students.AddAsync(std);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0 || context.Students == null)
            {
                return NotFound();
            }
           var stdData = await context.Students.FirstOrDefaultAsync(x => x.Id == id);
            return View(stdData);
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0 || context.Students == null)
            {
                return NotFound();
            }
            var stdData = await context.Students.FindAsync(id);
            return View(stdData);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                context.Students.Update(std);
                await context.SaveChangesAsync();
               // var stdData = await context.Students.ToListAsync();
                return RedirectToAction("Index");
                
            }
            return View();
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0 || context.Students == null)
            {
                return NotFound();
            }
            var stdData = await context.Students.FindAsync(id);
            if (stdData != null)
            {
                context.Students.Remove(stdData);
                await context.SaveChangesAsync();
            }
            //var stdData = await context.Students.ToListAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
