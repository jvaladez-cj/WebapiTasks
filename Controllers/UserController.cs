using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebapiTasks.Models;

namespace WebapiTasks.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    [Route("store")]
    public dynamic store(User user)
    {
        user.Id = 1;
        return new
        {
            success = true
        };
    }
}
