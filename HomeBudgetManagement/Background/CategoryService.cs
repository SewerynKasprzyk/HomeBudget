using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Database;
using Database.Entities;

namespace Model
{
    public class CategoryService
    {
        private readonly HomeManagementDbContext _context;

        public CategoryService(HomeManagementDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Set<Category>().Find(id);
        }

        public void Add(Category category)
        {
            _context.Set<Category>().Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Set<Category>().Find(id);
            if (category != null)
            {
                _context.Set<Category>().Remove(category);
                _context.SaveChanges();
            }
        }
    }
}