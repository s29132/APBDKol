using Microsoft.EntityFrameworkCore;
using WebApplication2.Properties.Context;
using WebApplication2.Properties.ModelDTOs;
using WebApplication2.Properties.Models;

namespace WebApplication2.Properties.Service;

public interface IUserService
{
    ProjectDto? GetProject(int IdProject);
}
public class UserService : IUserService
{
    public MyDbContext _DbContext { get; set; }
    public UserService(MyDbContext dbContext)
    {
        _DbContext = dbContext;
    }
    
    public ProjectDto? GetProject(int IdProject)
    {
        var project = _DbContext.Projects.Where(u => u.IdProject == IdProject).Select(u => new ProjectDto
        {
            IdProject = u.IdProject,
            Name = u.Name,
            IdDefaultAssignee = u.IdDefaultAssignee
        }).FirstOrDefault();
        return project;
    }
}