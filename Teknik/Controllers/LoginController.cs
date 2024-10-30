using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teknik.Concrete;
using System.Threading.Tasks;
using System.Linq;

namespace Teknik.Controllers
{
    public class LoginController:Controller
    {
        private readonly AddDbContext _dbContext;
        public LoginController(AddDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(string email, string sifre)
        {
            // Kullanıcı kontrolü
            var user = await _dbContext.Users
                .Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync(u => u.Email == email && u.Sifre == sifre);

            if (user != null)
            {
                // Kullanıcının rolünü kontrolü
                var userRole = user.UserRoles.FirstOrDefault()?.Role?.Ad;

                if (userRole == "admin")
                {
                    return RedirectToAction("AdminDashboard", "Admin");
                }
                else if (userRole == "user")
                {
                    return RedirectToAction("UserDashboard", "User");
                }
            }

            // Hatalı şifre ya da mail 
            ViewBag.Error = "Geçersiz kullanıcı adı veya şifre.";
            return View();
        }

    }
}
