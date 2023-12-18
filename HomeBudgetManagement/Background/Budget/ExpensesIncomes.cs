using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class ExpensesIncomes //Nazwa do zmiany jbc
    {
        public ExpensesIncomes(String name, double value, Budget budget)
        {
            this.Name = name;
            this.Value = value;
            this.AccouuntId = budget.BudgetId;
        }

        public int AccouuntId { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
