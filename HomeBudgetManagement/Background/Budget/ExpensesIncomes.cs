using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class ExpensesIncomes //Nazwa do zmiany jbc
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public ExpensesIncomes(String name, double value)
        {
            this.Name = name;
            this.Value = value;
        }

    }
}
