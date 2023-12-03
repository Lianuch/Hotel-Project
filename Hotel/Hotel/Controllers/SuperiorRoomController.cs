using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class SuperiorRoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuperiorRoomController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> superior = _context.Rooms.ToList();
            return View(superior);
        }
    }
}
