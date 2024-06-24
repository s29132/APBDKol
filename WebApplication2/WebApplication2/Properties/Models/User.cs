using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Properties.Models;

public class User
{
    [Key]
    public int IdUser { get; set; }
    
    [MaxLength(200)]
    [Required]
    public string FirstName { get; set; }
    [MaxLength(200)]
    [Required]
    public string LastName { get; set; }
    
    public ICollection<Project> Projects { get; set; }
    
}