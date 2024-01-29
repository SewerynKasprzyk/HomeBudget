﻿using Database;
using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Background.Manager
{
    public class GoalManager
    {
        private GoalService _goalService;
        private UserService _userService;

        public Goal AddGoal(String name, String amount)
        {
            var goal = new Goal();
            var user = _userService.GetUser(Configuration.LoggedUser.Id);
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
        
        public bool DeleteGoal(Goal goal)
        {
            _goalService.DeleteGoal(goal.Id);
            return true;
        }

        public List<Goal> GetAllMyGoals()
        {
            return _goalService.GetAllGoals(Configuration.LoggedUser.Id);
        }

    }

}
 