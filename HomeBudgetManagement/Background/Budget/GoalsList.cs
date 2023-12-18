using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    class GoalsList
    {
        public List<Goal> Goals { get; set; }

        public void AddToList(Goal goal)
        {
            Goals.Add(goal);
        }

        public void RemoveFromList(Goal goal) 
        {
            Goals.Remove(goal);        
        }
    }
}
