using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class Budget
    {
        
        public Budget() 
        {
            this.BudegtValue = 0;
            this.BudgetId = 0;
            this.BudgetLimit = 0;
        }

        public Budget(float value, Account account)
        {
            this.BudegtValue = value;
            this.BudgetId = int.Parse(account.AccountId);
            this.BudgetLimit = 0;
        }
        
        public void AddToBudget(float value)
        {
            BudegtValue += value;
        }

        public void SubFromBudget(float value)
        {
            BudegtValue -= value;
        }

        private static int budgetId = 0;
        private float budegtValue;
        private float budgetLimit;
        private Limit limit;

        public float BudegtValue { get ; set; }
        public int BudgetId { get; set; }
        public float BudgetLimit {  get; set; }
        public Limit Limit { get => limit; set => limit = value; }
    }
}
