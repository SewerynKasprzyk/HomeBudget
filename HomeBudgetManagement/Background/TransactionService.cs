using System.Data.Entity;
using Database.Entities;
using Database;

namespace Model
{
    public class TransactionService
    {
        private HomeManagementDbContext _context;

        public TransactionService(HomeManagementDbContext context)
        {
            _context = context;
        }

        // Create
        public Transaction CreateTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }

        // Read
        public Transaction GetTransaction(int id)
        {
            return _context.Transactions.Find(id);
        }

        // Update
        public Transaction UpdateTransaction(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            _context.SaveChanges();
            return transaction;
        }

        // Delete
        public void DeleteTransaction(int id)
        {
            var transaction = _context.Transactions.Find(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}
