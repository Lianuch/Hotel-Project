using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAll();
        Task<Restaurant> GetByIdAsync(int id);
        Task<IEnumerable<Restaurant>> GetAllRestaurant(string floor);
        bool Add(Restaurant restaurant);
        bool Update(Restaurant restaurant);
        bool Delete(Restaurant restaurant);
        bool Save();
    }
}
