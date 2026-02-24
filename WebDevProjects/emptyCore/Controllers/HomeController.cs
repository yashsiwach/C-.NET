using emptyCore.Models;
using Microsoft.AspNetCore.Mvc;
using emptyCore.Repository;

namespace emptyCore.Controllers
{
    
    [Route("[Controller]/[Action]")]
    public class HomeController : Controller
    {
        private readonly StudentRepository studentRepository;
        public HomeController() 
        {
            studentRepository = new StudentRepository();
        }
        public List<Student> GetAllStudents() 
        {
            return studentRepository.GetAllStudents();
        }
        [Route("~/Home/GetStudentById/{id}")]
        public Student GetStudentById(int id) 
        {
            return studentRepository.GetStudentById(id);
        }
        [Route("")]
        [Route("Index")]

        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {

            ViewData["data1"] = "Hello World!";
            ViewData["data2"] = 334;
            ViewData["data3"] = new List<string>() { "a", "b", "c" };
            TempData["data4"] = "Hello World!";
            TempData.Keep();
            return View();
        }
        public new IActionResult User()
        {
            ViewBag.data1 = "Hello World!";
            ViewBag.data2 = 34;
            ViewBag.data3 = new List<string>() { "a", "b", "c" };

            return View();
        }
        public new IActionResult StudentData() {
             List<Student> Data = new List<Student> { 
                new Student { Id = 1, Name = "John", Age = 20 },
                new Student { Id = 2, Name = "Jane", Age = 22 },
                new Student { Id = 3, Name = "Bob", Age = 21 }
            };
            ViewBag.data = Data;
            return View();
        }
        [Route("~/Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id??1;
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

    }
}
