using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class BudgetList
    {    
        public BudgetList() 
        {
            this.Budgets = new List<Budget>();
        }

        public void AddBudget(Budget item)
        {
            this.Budgets.Add(item);
        }

        public void SubBudget(Budget item)
        {
            this.Budgets.Remove(item);
        }

        public List<Budget> Budgets { get; set; }

        private List<Budget> budgets;
    }

}
