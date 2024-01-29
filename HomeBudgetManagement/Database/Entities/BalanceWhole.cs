using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class BalanceWhole
    {
        [Key]
        public int Id { get; set; }
        public decimal Value { get; set; }
        public decimal Limit { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
