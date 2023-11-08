using Hotel.Data;
using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        public RoomController(IRoomRepository roomRepository)
        { 
            _roomRepository = roomRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Room> rooms = await _roomRepository.GetAll();
            return View(rooms);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Room room =  await _roomRepository.GetByIdAsync(id);
            return View(room);
        }

    }
}
