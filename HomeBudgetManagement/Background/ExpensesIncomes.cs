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

        ExpensesIncome(String name, double value)
        {
            this.name = name;
            this.value = value;
        }

        private double value;
        private String name;

    }
}
