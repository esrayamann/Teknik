using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teknik.Concrete;

namespace Teknik.Controllers
{
    public class ServisKayitController : Controller
    {
        private readonly AddDbContext _dbContext;
        public ServisKayitController(AddDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            var kayitlar = await _dbContext.Kayitlar.ToListAsync();
            return View(kayitlar);
        }
        [HttpGet]
        public IActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> YeniKayit(ServisKayit kayit)
        {
            if(ModelState.IsValid) 
                {
                    _dbContext.Kayitlar.Add(kayit);
                await _dbContext.SaveChangesAsync();    
                return RedirectToAction("Index");
                }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Guncelle(int id)
        {
            var kayit=await _dbContext.Kayitlar.FindAsync(id);
            if (kayit == null)
            {
                return NotFound();
            }
            return View(kayit);
        }
        [HttpPost]
        public async Task<IActionResult> Guncelle(int id,ServisKayit kayit)
        {
            if(id != kayit.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                _dbContext.Entry(kayit).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(kayit);
        }
    }
}
