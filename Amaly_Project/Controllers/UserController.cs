using Amaly_Project.Data;
using Amaly_Project.Models;
using Amaly_Project.Service.Interfeys;
using Microsoft.AspNetCore.Mvc;

namespace Amaly_Project.Controllers
{
    [ApiController]
    [Route("[Api/controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(EFcoreContext eFcoreContext, IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            if (_userService == null)
            {
                return NotFound();
            }
            return await _userService.get
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            _userService.Add(user);
            return Ok("Sucecfully");
        }
    }
}
