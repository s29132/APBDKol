using System.ComponentModel.DataAnnotations;
using WebApplication2.Properties.Models;

namespace WebApplication2.Properties.ModelDTOs;

public class UserDto
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