using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveBoo.Models
{
    [Table("Profile")]
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public Restaurant Restaurant { get; set; }
        
    }
}
