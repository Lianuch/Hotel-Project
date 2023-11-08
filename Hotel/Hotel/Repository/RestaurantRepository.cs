using Hotel.Data;
using Hotel.Data.Enum;
using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;
namespace Hotel.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;
        public RestaurantRepository(ApplicationDbContext context) 
        {
        _context = context;
        }

        public bool Add(Restaurant restaurant)
        {
            _context.Add(restaurant);
            return Save();
        }

        public bool Delete(Restaurant restaurant) 
        {
            _context.Remove(restaurant);
            return Save();
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task<Restaurant> GetByIdAsync(int id)
        {
            return await _context.Restaurants.Include(i=>i.InfoUser).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurant(string floor)
        {
            return await _context.Restaurants.Where(c => c.InfoUser.Floor.Contains(floor)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Restaurant restaurant)
        {
            _context.Update(restaurant);
            return Save();
        }
    }
}
