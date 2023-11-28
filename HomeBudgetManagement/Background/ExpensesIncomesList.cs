using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class ExpensesIncomesList
    {
        public static List<ExpensesIncomes> ExpensesList { get => expensesList; set => expensesList = value; }
        public static List<ExpensesIncomes> IncomesList { get => incomesList; set => incomesList = value; }

        public static void AddToList(ExpensesIncomes expInc)
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
        
        private static List<ExpensesIncomes> expensesList;
        private static List<ExpensesIncomes> incomesList;
    }
}
