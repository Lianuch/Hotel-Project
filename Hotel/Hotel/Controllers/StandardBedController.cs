using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class StandardBedController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StandardBedController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> standardBed = _context.Rooms.ToList();
            return View(standardBed);
        }
    }
}
