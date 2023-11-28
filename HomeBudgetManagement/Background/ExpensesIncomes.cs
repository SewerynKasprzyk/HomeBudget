using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class ExpensesIncomes //Nazwa do zmiany jbc
    {
        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }

        ExpensesIncomes(String name, double value)
        {
            this.name = name;
            this.value = value;
        }

        private double value;
        private String name;

    }
}
