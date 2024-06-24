using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Properties.Models;

public class TaskT
{
    [Key]
    public int IdTask { get; set; }
    [MaxLength(200)]
    [Required]
    public string Name { get; set; }
    [MaxLength(1000)]
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public int IdProject { get; set; }
    [Required]
    public int IdReporter { get; set; }
    [Required]
    public int IdAssignee { get; set; }
    
    [ForeignKey(nameof(IdAssignee))]
    public User User { get; set; }
    
    [ForeignKey(nameof(IdProject))]
    public Project Project { get; set; }
    
    [ForeignKey(nameof(IdReporter))]
    public User UserReporter { get; set; }
}