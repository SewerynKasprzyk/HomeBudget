using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Limit { get; set; }
    }
}
