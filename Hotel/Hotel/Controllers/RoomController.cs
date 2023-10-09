using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RoomController(ApplicationDbContext context)
        { 
           _context = context;
        }
        public IActionResult Index()
        {
            List<Room> rooms = _context.Rooms.ToList();
            return View(rooms);
        }
    }
}
