using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class Limit
    {
        private int limitID;
        private int accountID;
        private float limitValue;
        private float actualValue = 0;

        private String name = "Error";
        private String description ="";

        public Limit(int limitID, int accountID, float limitValue, string name)
        {
            this.limitID = limitID;
            this.accountID = accountID;
            this.limitValue = limitValue;
            this.name = name;
        }

        public Limit(int limitID, int accountID, float limitValue, float actualValue, string name, string description)
        {
            this.limitID = limitID;
            this.accountID = accountID;
            this.limitValue = limitValue;
            this.actualValue = actualValue;
            this.name = name;
            this.description = description;
        }

        public int LimitID { get => limitID; set => limitID = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public float LimitValue { get => limitValue; set => limitValue = value; }
        public float ActualValue { get => actualValue; set => actualValue = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public float GetCompletion()
        {
            return actualValue / limitValue;
        }
        public void UpdateValue(float add)
        {
            this.actualValue += add;
        }

    }
}
