using System.Threading.Tasks;
using System.Web.Http;
using TeamBackend.Models;
using TeamBackend.Services;

namespace TeamBackend.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create(UserData user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Create(user);
            if (result)
                return Ok("User created successfully.");
            else
                return InternalServerError();
        }

        
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> Update(int id, UserData user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.Id = id; 
            var result = await _userService.Update(user);

            if (result)
                return Ok("User updated successfully.");
            else
                return NotFound(); 
        }
    }
}
