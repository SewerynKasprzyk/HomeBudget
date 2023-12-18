using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    class Goal
    {
        public Goal(int id, string name, float limit)
        {
            Id = id;
            Name = name;
            Limit = limit;
            Value = 0;
            Deadline = -1; //jeżeli -1 to goal jest bezterminowy
        }

        public void AddToValue(float value) { Value += value; }
        public void SubFromValue(float value) { Value -= value; }   

        public int Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public float Limit { get; set; }
        public int Deadline { get; set; }
    }
}
