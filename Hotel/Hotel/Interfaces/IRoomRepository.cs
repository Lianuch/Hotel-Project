using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> GetByIdAsync(int id);
        Task<IEnumerable<Room>> GetRoomByFloor(string floor); 
        bool Add(Room room);
        bool Update(Room room);
        bool Delete(Room room);
        bool Save();
    }
}
