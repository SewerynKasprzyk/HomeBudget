using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public decimal Amonunt { get; set; } 
        public string Name { get; set; }    

    }
}
