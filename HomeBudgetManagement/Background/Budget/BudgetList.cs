using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class BudgetList
    {
        public static Budget GetBudget(int budgetID)
        {
            foreach (Budget budget in budgets)
            {
                if (budget.BudgetId == budgetID)
                {
                    return budget;
                }
            }

            return new Budget();
        }

        static BudgetList() 
        {
            Budgets = new List<Budget>();
        }

        public static void AddBudget(Budget item)
        {
            Budgets.Add(item);
        }

        public static void SubBudget(Budget item)
        {
            Budgets.Remove(item);
        }

        public static List<Budget> Budgets { get; set; }

        private static List<Budget> budgets;
    }

}
