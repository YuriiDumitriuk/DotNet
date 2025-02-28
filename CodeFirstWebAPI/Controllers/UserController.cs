using CodeFirstWebAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using CodeFirstWebAPI.DatabaseContext;
using CodeFirstWebAPI.Services;

namespace CodeFirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class UserController : Controller
    {
        private readonly UserService userService = new UserService();
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }
        [HttpGet("id")]
        public User GetUserByID(int id)
        {
            return userService.GetUserById(id);
        }
        [HttpGet("name")]
        public User GetUserByName(string name)
        {
            return userService.GetUserByName(name);
        }
    }
}
