using Microsoft.AspNetCore.Mvc;
using MVCwithAPI.Models;
using System.Diagnostics;

namespace MVCwithAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
