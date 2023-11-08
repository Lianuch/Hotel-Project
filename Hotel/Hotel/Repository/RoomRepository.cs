using Hotel.Data;
using Hotel.Data.Enum;
using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;
        public RoomRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public bool Add(Room room)
        {
            _context.Add(room);
            return Save();
        }

        public bool Delete(Room room)
        {
            _context.Remove(room);
            return Save();
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
          return await  _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetByIdAsync(int id)
        {
            return await _context.Rooms.Include(i=>i.InfoUser).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Room>> GetRoomByFloor(string floor)
        {
            return await _context.Rooms.Where(c=>c.InfoUser.Floor.Contains(floor)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Room room)
        {
            _context.Update(room);
            return Save();
        }
    }
}
