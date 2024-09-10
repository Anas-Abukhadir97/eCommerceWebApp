using eCommerceWebApp.Date;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebApp.Controllers
{
    public class CinemasController : Controller
    {
        private readonly clsAppDbContext _DbContext;

        public CinemasController(clsAppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IActionResult> Index()
        {
            var CinemasData = await _DbContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
