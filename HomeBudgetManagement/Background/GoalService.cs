using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Database;
using Database.Entities;

namespace Model
{
    public class GoalService
    {
        private HomeManagementDbContext _context;

        public GoalService(HomeManagementDbContext context)
        {
            _context = context;
        }

        // Create
        public Goal CreateGoal(Goal goal)
        {
            _context.Goals.Add(goal);
            _context.SaveChanges();
            return goal;
        }

        // Read
        public Goal GetGoal(int id)
        {
            return _context.Goals.Find(id);
        }

        // Update
        public Goal UpdateGoal(Goal goal)
        {
            _context.Entry(goal).State = EntityState.Modified;
            _context.SaveChanges();
            return goal;
        }

        public List<Goal> GetAllGoals(long id)
        {
            return _context.Goals.Where(x => x.User.Id == id).ToList();
        }

        // Delete
        public void DeleteGoal(int id)
        {
            var goal = _context.Goals.Find(id);
            if (goal != null)
            {
                _context.Goals.Remove(goal);
                _context.SaveChanges();
            }
        }
    }
}
