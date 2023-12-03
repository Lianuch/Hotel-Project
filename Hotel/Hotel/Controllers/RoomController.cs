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
        public async Task<IActionResult> JuniorSuite(int id)
        {
            Room junior = await _roomRepository.GetByIdAsync(id);
            return View(junior);
        }
        public async Task<IActionResult> DeluxeRoom(int id)
        {
            Room deluxe = await _roomRepository.GetByIdAsync(id);
            return View(deluxe);
        }
        public async Task<IActionResult> PresidentalApartaments(int id)
        {
            Room presidental = await _roomRepository.GetByIdAsync(id);
            return View(presidental);
        }

        public async Task<IActionResult> StandardBed(int id)
        {
            Room standardBed = await _roomRepository.GetByIdAsync(id);
            return View(standardBed);
        }
        public async Task<IActionResult> StandardDouble(int id)
        {
            Room standardDouble = await _roomRepository.GetByIdAsync(id);
            return View(standardDouble);
        }
        public async Task<IActionResult> SuperiorRoom(int id)
        {
            Room superior = await _roomRepository.GetByIdAsync(id);
            return View(superior);
        }


    }
}
