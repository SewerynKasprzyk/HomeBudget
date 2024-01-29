using Database;
using Database.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public class UserService
    {
        private HomeManagementDbContext _context;

        public UserService(HomeManagementDbContext context)
        {
            _context = context;
        }

        // Create
        public User CreateUser(User user)
        {
            user.Balance = new Balance();
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        // Read
        public User GetUser(long id)
        {
            return _context.Users.Find(id);
        }

        // Update
        public User UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return user;
        }

        // Delete
        public void DeleteUser(long id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public Balance GetUserBalance(int userId)
        {
            var user = _context.Users.Find(userId);
            return user != null ? user.Balance : null;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}