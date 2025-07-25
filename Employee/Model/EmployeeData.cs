using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class EmployeeData
{
    [Key]
    [JsonPropertyName("employeId")]
    public int EmployeId { get; set; }

    [Required]
    [MaxLength(50)]
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [Required]
    [MaxLength(50)]
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [MaxLength(10)]
    [MinLength(1)]
    [JsonPropertyName("contactnumber")]
    public string Contactnumber { get; set; }

    [MaxLength(50)]
    [JsonPropertyName("city")]
    public string City { get; set; }
}
