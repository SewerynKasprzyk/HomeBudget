using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    internal class Limit
    {
        private int limitID;
        private float limitValue;
        private float actualValue;

        private String name;
        private String description;

        public float GetCompletion()
        {
            return actualValue / limitValue;
        }
        public void UpdateValue(float add)
        {
            this.actualValue += add;
        }
        public Limit(int limitID, float limitValue, string name)
        {
            this.limitID = limitID;
            this.limitValue = limitValue;
            this.actualValue = 0;
            this.name = name;
            this.description = name;
        }

        public Limit(int limitID, float limitValue, float actualValue, string name, string description)
        {
            this.limitID = limitID;
            this.limitValue = limitValue;
            this.actualValue = actualValue;
            this.name = name;
            this.description = description;
        }

        public int LimitID { get => limitID; set => limitID = value; }
        public float LimitValue { get => limitValue; set => limitValue = value; }
        public float ActualValue { get => actualValue; set => actualValue = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
