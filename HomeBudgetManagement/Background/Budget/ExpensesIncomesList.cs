using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class ExpensesIncomesList
    {
        static ExpensesIncomesList()
        {
            ExpensesList = new List<ExpensesIncomes> ();
        }
        public static List<ExpensesIncomes> ExpensesList { get; set ; }

        public static void AddToList(ExpensesIncomes expInc)
        {
            ExpensesList.Add(expInc);
        }
    }
}
