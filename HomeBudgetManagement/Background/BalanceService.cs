using Database.Entities;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public class BalanceService
    {
        private readonly DbContext _context;

        public BalanceService(DbContext context)
        {
            _context = context;
        }

        public IQueryable<Balance> GetAll()
        {
            return _context.Set<Balance>().Include(b => b.User).Include(b => b.Transactions);
        }

        public Balance GetById(int id)
        {
            return _context.Set<Balance>().Include(b => b.User).Include(b => b.Transactions).SingleOrDefault(b => b.Id == id);
        }

        public void Add(Balance balance)
        {
            _context.Set<Balance>().Add(balance);
            _context.SaveChanges();
        }

        public Balance Update(Balance balance)
        {
            _context.Entry(balance).State = EntityState.Modified;
            _context.SaveChanges();
            return balance;
        }

        public void Delete(int id)
        {
            var balance = _context.Set<Balance>().Find(id);
            if (balance != null)
            {
                _context.Set<Balance>().Remove(balance);
                _context.SaveChanges();
            }
        }
    }
}