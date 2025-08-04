using System.Collections.Generic;

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
        // POST: api/users/create
        [HttpPost]
        [Route("create")]
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


        // GET: api/users

        [HttpGet]

        [Route("")]

        public async Task<IHttpActionResult> GetAll()

        {

            var users = await _userService.GetAll();

            return Ok(users);

        }

        // DELETE: api/users/{id}

        [HttpDelete]

        [Route("{id:int}")]

        public async Task<IHttpActionResult> Delete(int id)

        {

            var result = await _userService.Delete(id);

            if (result)

                return Ok("User deleted successfully.");

            else

                return NotFound();

        }

    }

}