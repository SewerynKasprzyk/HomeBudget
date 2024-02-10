using Database;
using Database.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public class TransactionService
    {
        private HomeManagementDbContext _context;

        public TransactionService(HomeManagementDbContext context)
        {
            _context = context;
        }

        public List<Transaction> GetAll()
        {
            return _context.Set<Transaction>().Include(t => t.User).Include(t => t.Category).ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.Set<Transaction>().Include(t => t.User).Include(t => t.Category).SingleOrDefault(t => t.Id == id);
        }

        public void Add(Transaction transaction)
        {
            _context.Set<Transaction>().Add(transaction);
            _context.SaveChanges();
        }

        public void Update(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var transaction = _context.Set<Transaction>().Find(id);
            if (transaction != null)
            {
                _context.Set<Transaction>().Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}
