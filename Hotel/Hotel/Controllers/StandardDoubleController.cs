using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class StandardDoubleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StandardDoubleController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> standardDouble = _context.Rooms.ToList();
            return View(standardDouble);
        }
    }
}
