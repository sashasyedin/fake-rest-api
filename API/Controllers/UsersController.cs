using Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            // Please make sure that you register one of the services in the Startup class:
            _userService = userService;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var user = _userService.GetUser(id);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.ListUsers();
            return Ok(users);
        }
    }
}
