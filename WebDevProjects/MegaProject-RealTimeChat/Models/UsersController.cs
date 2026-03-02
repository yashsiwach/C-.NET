using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public UsersController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;

    }
    public IActionResult Index()
    {
        var currentUserId = _userManager.GetUserId(User);

        var users = _userManager.Users
            .Where(u => u.Id != currentUserId)
            .ToList();

        return View(users);
    }
}