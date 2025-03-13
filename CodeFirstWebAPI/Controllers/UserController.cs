using CodeFirstWebAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using CodeFirstWebAPI.DatabaseContext;
using CodeFirstWebAPI.Services;

namespace CodeFirstWebAPI.Controllers;

[ApiController]
[Route("[controller]")] // user

public class UserController : Controller
{

    private readonly IUserService userService;

    public UserController(IUserService userService) {
        this.userService = userService;
    }
    
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(userService.GetAllUsers());
    }

    [HttpGet("id")]
    public IActionResult GetUserByID(int id)
    {
        if (id == 0)
        {
            return BadRequest("Id cannot be 0");
        }
        return Ok(userService.GetUserById(id));

    }

    [HttpGet("name")]
    public IActionResult GetUserByName(string name)
    {
        if (name == null)
        {
            return BadRequest("Name cannot be empty");
        }
        return Ok(userService.GetUserByName(name));
    }



    //[HttpGet("id")]
    //public IActionResult GetUserByID(int id)
    //{
    //    if (id == 0)
    //    {
    //        return BadRequest("Id cannot be 0");
    //    }
    //    return Ok(userService.GetUserById(id));

    //}

    //[HttpGet("name")]
    //public IActionResult GetUserByName(string name)
    //{
    //    if (name == null)
    //    {
    //        return BadRequest("Name cannot be empty");
    //    }
    //    return Ok(userService.GetUserByName(name));
    //}
}





