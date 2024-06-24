using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Properties.Models;

public class Project
{
    [Key]
    public int IdProject { get; set; }
    public string Name { get; set; }
    public int IdDefaultAssignee { get; set; }
    
    [ForeignKey(nameof(IdDefaultAssignee))]
    public User User { get; set; }
}