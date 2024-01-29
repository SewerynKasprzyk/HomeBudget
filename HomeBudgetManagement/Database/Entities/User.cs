using Database.Enums;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Balance Balance { get; set; }
        public Role Role { get; set; }
        public decimal Limit { get; set; }
    }
}
