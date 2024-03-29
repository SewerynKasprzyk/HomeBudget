﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Balance
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public decimal Value { get; set; }
        public decimal Limit { get; set; }
        public virtual User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
