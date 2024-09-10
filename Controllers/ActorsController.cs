using eCommerceWebApp.Date;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly clsAppDbContext _DbContext;

        public ActorsController(clsAppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IActionResult> Index()
        {
            var ActorsData = await _DbContext.Actors.ToListAsync();
            return View(ActorsData);
        }
    }
}
