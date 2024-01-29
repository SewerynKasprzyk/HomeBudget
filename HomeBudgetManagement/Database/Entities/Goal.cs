using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; } 
        public string Name { get; set; } 
        public User User { get; set; } 
    }
}
