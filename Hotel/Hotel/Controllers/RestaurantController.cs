using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RestaurantController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Restaurant> restaurants = _context.Restaurants.ToList();
            return View(restaurants);
        }
    }
}
