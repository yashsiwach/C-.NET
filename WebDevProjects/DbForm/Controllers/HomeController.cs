using DbForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DbForm.Controllers
{
    public class HomeController : Controller
    {
        private static List<Student> students = new();
        [HttpGet]
        public IActionResult Index()
        {
            //string name = "india,pakistan,china";
            //var list = name.Split(',').ToList();
            //ViewBag.stores = list;
            string sessionId = HttpContext.Session.Id;
            ViewBag.SessionId = sessionId;
            ViewBag.processes = Process.GetProcessesByName("ulaa");
            return View();
        }
        [HttpPost]
        public IActionResult Result(Student student)
        {
            if (!ModelState.IsValid)
            {
                
                return View("Index", student);
            }
            students.Add(student);

            return View("Index");
        }
        public IActionResult ViewStudents()
        {
            return View(students);
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
