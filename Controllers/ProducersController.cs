using eCommerceWebApp.Date;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceWebApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly clsAppDbContext _DbContext;

        public ProducersController(clsAppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<IActionResult> Index()
        {
            var ProducersData = _DbContext.Actors.ToListAsync();
            return View();
        }
    }
}
