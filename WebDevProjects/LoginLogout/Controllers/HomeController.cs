using LoginLogout.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginLogout.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext context;

        public HomeController(CodeFirstDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                ViewBag.signup = "Registration successful. Please login.";
                return RedirectToAction("Login");
            }

            return View();
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("DashBoard");
                
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var res=context.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
            if (res==null) {
                ViewBag.Message = "Invalid email or password";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("username", res.Name);
                return RedirectToAction("DashBoard");
            }
            
        }
        public IActionResult DashBoard()
        {
            if(HttpContext.Session.GetString("username")!=null)
            {
                ViewBag.mysession = HttpContext.Session.GetString("username").ToString();
                return View();
            }
            else

            {
                return RedirectToAction("Login");
            }
            
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("Login");
            }
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
