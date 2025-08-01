using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Navigation property
        public ICollection<TodoTask> Tasks { get; set; }
    }
}
