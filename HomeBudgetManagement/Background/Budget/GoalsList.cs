using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public static class GoalsList
    {
        static GoalsList()
        {
            Goals = new List<Goal>();
        }
        public static List<Goal> Goals { get; set; }

        public static Goal GetGoal(int GoalID)
        {
            foreach (Goal goal in Goals)
            {
                if(goal.Id == GoalID)
                {
                    return goal;
                }
            }

            return new Goal();
        }

        public static void AddToList(Goal goal)
        {
            Goals.Add(goal);
        }

        public static void RemoveFromList(Goal goal) 
        {
            Goals.Remove(goal);        
        }
    }
}
