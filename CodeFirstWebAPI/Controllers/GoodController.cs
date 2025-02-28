using CodeFirstWebAPI.Entities;
using CodeFirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class GoodController : Controller
    {
        
        private readonly GoodService goodService = new GoodService();
        [HttpGet]
        public List<Good> GetAllGoods()
        {
            return goodService.GetAllGoods();
        }

        [HttpGet("id")]
        public Good GetGoodByID(int id)
        {
            return goodService.GetGoodById(id);
        }
        [HttpGet("name")]
        public Good GetGoodByName(string name)
        {
            return goodService.GetGoodByName(name);
        }
    }
}
