using eCommerceWebApp.Date;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly clsAppDbContext _DbContext;

        public MoviesController(clsAppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<IActionResult> Index()
        {
            var MoviesData = _DbContext.Movies.ToListAsync();
            return View();
        }
    }
}
