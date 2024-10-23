using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Teknik.Controllers
{
    public class LoginController:Controller
    {
        private readonly DbContext _dbContext;
        public LoginController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
