using System;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; }
        public string Priority { get; set; } = "Normal";
        // Foreign key
        public int UserId { get; set; }

        // Navigation property
        public User User { get; set; }


    }
}
