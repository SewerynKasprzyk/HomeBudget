using Database;
using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
using System;
using System.Collections.Generic;

namespace Model.Manager
{
    public class GoalManager
    {
        private GoalService _goalService;
        private UserService _userService;

        public Goal AddGoal(String name, String amount)
        {
            var goal = new Goal();
            var user = _userService.GetUser(Configuration.LoggedUserID);
            goal = new Goal() { Amount = Convert.ToDecimal(amount), Name = name, User = user };
            goal = _goalService.CreateGoal(goal);
            return goal;
        }
        public GoalManager()
        {
            var db = new HomeManagementDbContext();
            _userService = new UserService(db);
            _goalService = new GoalService(db);
        }

        public bool UpdateName(Goal oldGoal, string name)
        {
            oldGoal.Name = name;
            _goalService.UpdateGoal(oldGoal);
            return true;
        }

        public bool UpdateAmount(Goal oldGoal, decimal value)
        {
            oldGoal.Amount = value;
            _goalService.UpdateGoal(oldGoal);
            return true;
        }

        public bool UpdateCurrentAmount(Goal oldGoal, decimal value)
        {
            oldGoal.CurrentAmount = value;
            _goalService.UpdateGoal(oldGoal);
            return true;
        }

        public bool AddToGoal(Goal oldGoal, decimal value)
        {
            oldGoal.CurrentAmount += value;
            _goalService.UpdateGoal(oldGoal);
            return true;
        }
        public bool SubGoal(Goal oldGoal, decimal value)
        {
            oldGoal.CurrentAmount -= value;
            _goalService.UpdateGoal(oldGoal);
            return true;
        }

        public bool DeleteGoal(Goal goal)
        {
            _goalService.DeleteGoal(goal.Id);
            return true;
        }

        public List<Goal> GetAllMyGoals()
        {
            return _goalService.GetAllGoals(Configuration.LoggedUserID);
        }

    }

}
 