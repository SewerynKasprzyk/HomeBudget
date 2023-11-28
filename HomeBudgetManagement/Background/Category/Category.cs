using System.Collections.Generic;

namespace Background
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        //demo
        public Category(string name, int id) 
        {
            Name = name;
            Id = id;
        }
    }
}