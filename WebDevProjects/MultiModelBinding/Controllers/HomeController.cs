using Microsoft.AspNetCore.Mvc;
using MultiModelBinding.Models;
using System.Diagnostics;

namespace MultiModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id =1, Name = "Student 1",Gender ="Male" },
                new Student { Id =2, Name = "Student 2",Gender ="Female" },
                new Student { Id =3, Name = "Student 3",Gender="male" }
             };
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id =1, Name = "Teacher 1",Subject ="Math" },
                new Teacher { Id =2, Name = "Teacher 2",Subject ="Science" },
                new Teacher { Id =3, Name = "Teacher 3",Subject="History" }
            };
            SchoolViewModel viewModel = new SchoolViewModel();
            viewModel.Students = students;
            viewModel.Teachers = teachers;
            return View(viewModel);
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id =1, Name = "Camra ",Description ="Description for Product 1",ImageUrl="~/Images/Camra.jpg" },
                new Product { Id =2, Name = "Sampoo ",Description ="Description for Product 2",ImageUrl="~/Images/sampoo.jpg" },
                new Product { Id =3, Name = "Shoe",Description ="Description for Product 3",ImageUrl="~/Images/Shoe.jpg" }
            };
            return View(products);
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
