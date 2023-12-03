using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class juniorSuiteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public juniorSuiteController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room>junior = _context.Rooms.ToList();    
            return View(junior);
        }

    }
}
