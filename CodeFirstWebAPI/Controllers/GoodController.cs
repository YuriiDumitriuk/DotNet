using CodeFirstWebAPI.Entities;
using CodeFirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class GoodController : Controller
{

    private readonly IGoodService goodService;

    public GoodController(IGoodService goodService)
    {
        this.goodService = goodService;
    }

    [HttpGet]
    public IActionResult  GetAllGoods()
    {
        return Ok(goodService.GetAllGoods());
    }

    [HttpGet("id")]
    public IActionResult GetGoodByID(int id)
    {
        if (id == 0) 
        {
            return BadRequest("Id cannot be 0");
        }
        return Ok(goodService.GetGoodById(id));
    }
    [HttpGet("name")]
    public IActionResult GetGoodByName(string name)
    {
        if (name == null)
        {
            return BadRequest("Name cannot be empty");
        }
        return Ok(goodService.GetGoodByName(name));
    }
}
