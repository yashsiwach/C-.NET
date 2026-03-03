using Microsoft.AspNetCore.Mvc;
using CRUDwithMongoDB.Services;
using MongoCrudApp.Models;

namespace CRUDwithMongoDB.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService service;

        public StudentController(StudentService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var students = service.Get();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            service.Create(student);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string id)
        {
            var student = service.Get(id);
           return View(student);
        }
        [HttpPost]
        public IActionResult Edit(String Id, Student student)
        {
            service.Update(Id, student);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            service.Delete(service.Get(id));
            return RedirectToAction("Index");
        }
    }
}
