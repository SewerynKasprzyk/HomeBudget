using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    internal class ExpensesIncomesList
    {
        internal static List<ExpensesIncome> ExpensesList { get => expensesList; set => expensesList = value; }
        internal static List<ExpensesIncome> IncomesList { get => incomesList; set => incomesList = value; }

        public static void AddToList(ExpensesIncome expInc)
        {
            if(expInc.Value > 0)
            {
                incomesList.Add(expInc);
            }
            else
            {
                expensesList.Add(expInc);
            }  
        }
        
        private static List<ExpensesIncome> expensesList;
        private static List<ExpensesIncome> incomesList;
    }
}
