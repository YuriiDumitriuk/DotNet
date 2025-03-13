using CodeFirstWebAPI.Entities;
using CodeFirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class CartController : Controller
{
    private readonly ICartService cartService;
    public CartController(ICartService cartService) 
    {
        this.cartService = cartService;
    }

    [HttpGet("UserId")]
    public IActionResult  GetAllCartsByUserId(int id)
    {
        if (id == 0)
        {
            return BadRequest("Id cannot be 0");
        }
        return Ok(cartService.GetAllCartsByUserId(id));
        
    }
}
