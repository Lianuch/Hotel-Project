using Hotel.Data;
using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Restaurant> restaurants = await _restaurantRepository.GetAll();
            return View(restaurants);
        }
        public async Task<IActionResult> Detail(int id) 
        {
        Restaurant restaurant = await _restaurantRepository.GetByIdAsync(id);
            return View(restaurant);
        }
    }
}
