using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataWebAPI.Context;
using ODataWebAPI.Models;

namespace ODataWebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController(
    ApplicationDbContext context) : ControllerBase
{
    [HttpGet("users")]
    public IActionResult GetUsers(ODataQueryOptions<User> options)
    {
        var users = context.Users.AsQueryable();

        var res = options.ApplyTo(users);

        return Ok(res);
    }
}
