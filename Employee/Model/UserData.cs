using System;
using System.ComponentModel.DataAnnotations;

namespace Employee.Model
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)] // Store hashed password
        public string Password { get; set; } //

    }
}
