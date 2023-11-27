using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    internal class ExpensesIncome //Nazwa do zmiany jbc
    {
        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
        internal List<ExpensesIncome> ExpensesList { get => expensesList; }
        internal List<ExpensesIncome> IncomesList { get => incomesList; }

        ExpensesIncome(String name, double value)
        {
            this.name = name;
            this.value = value;
            this.income = isIncome1();
        }

        //sprawdzanie czy to wydatek czy przychod za pomoca wartosci ktora wpynela ???
        private bool isIncome1()
        {
            if(Value > 0)
            {
                incomesList.Add(this);
                return true;
            }
            else
            {
                expensesList.Add(this);
                return false;
            }
        }

        private bool isIncome()
        {
            return this.income;
        }



        private bool income;
        private double value;
        private String name;

        private List<ExpensesIncome> expensesList;
        private List<ExpensesIncome> incomesList;
    }
}
