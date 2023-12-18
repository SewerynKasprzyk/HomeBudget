using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public static class ExpensesIncomesList
    {
        public static List<ExpensesIncomes> ExpensesList { get; set ; }

        public static void AddToList(ExpensesIncomes expInc)
        {
            ExpensesList.Add(expInc);
        }
    }
}
