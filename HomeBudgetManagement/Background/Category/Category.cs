using System.Collections.Generic;

namespace Background
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
            Value = 0;
        }

        //demo
        public Category(string name, int id) 
        {
            Name = name;
            Id = id;
            Value = 0;
        }

        public void AddValue(float value)
        {
            Value += value;
        }

        public override string ToString()
        {
            return Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
    }
}