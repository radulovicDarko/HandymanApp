using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : Controller
    {
        private readonly IService _service;

        public UserController(IService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> TestGet(string id)
        {
            var users = await _service.GetUsers();
            return Ok(users);
        }
    }
}
