using Microsoft.AspNetCore.Mvc;

namespace Teknik.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminDash()
        {
            return View();
        }
    }
    public class UserController:Controller
    {
        public IActionResult UserDash()
        {
            return View();
        }
    }
}
