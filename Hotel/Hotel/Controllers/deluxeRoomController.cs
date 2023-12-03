using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class deluxeRoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public deluxeRoomController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> deluxe = _context.Rooms.ToList();
            return View(deluxe);
        }
    }
}
