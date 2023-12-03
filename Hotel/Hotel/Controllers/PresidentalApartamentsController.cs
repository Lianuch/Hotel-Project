using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class PresidentalApartamentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PresidentalApartamentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> presidental = _context.Rooms.ToList();
            return View(presidental);
        }
    }
}
