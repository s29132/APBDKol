using Microsoft.AspNetCore.Mvc;
using WebApplication2.Properties.Service;

namespace WebApplication2.Properties.Context.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    public IUserService _Service { get; set; }
    public UsersController(IUserService service)
    {
        _Service = service;
    }
    
    [HttpGet("{IdProject}")]
    public async Task<IActionResult> Get(int? IdProject)
    {
        if (IdProject != null)
        {
            var project = _Service.GetProject((int)IdProject);
            return Ok(project);
        }
    }
}