using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public static class BudgetList
    {
        static BudgetList()
        {
            
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

        //private List<Budget> budgets;
    }

}
