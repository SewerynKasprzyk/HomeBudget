using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
