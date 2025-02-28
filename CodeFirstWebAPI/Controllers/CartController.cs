using CodeFirstWebAPI.Entities;
using CodeFirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CartController : Controller
    {
        private readonly CartService cartService = new CartService();
        [HttpGet("UserId")]
        public List<Cart> GetAllCartsByUserId(int id)
        {
            return cartService.GetAllCartsByUserId(id);
        }
    }
}
