using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Properties.Models;

namespace WebApplication2.Properties.ModelDTOs;

public class ProjectDto
{
    [Key]
    public int IdProject { get; set; }
    
    [MaxLength(200)]
    [Required]
    public string Name { get; set; }
    [Required]
    public int IdDefaultAssignee { get; set; }
    
    public ICollection<Task> Tasks { get; set; }
}