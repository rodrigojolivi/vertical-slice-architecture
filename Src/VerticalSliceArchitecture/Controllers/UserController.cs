using MediatR;
using Microsoft.AspNetCore.Mvc;
using VerticalSliceArchitecture.Features.Users.CreateUser;
using VerticalSliceArchitecture.Features.Users.DeleteUser;
using VerticalSliceArchitecture.Features.Users.FindUser;
using VerticalSliceArchitecture.Features.Users.GetUser;
using VerticalSliceArchitecture.Features.Users.UpdateUser;

namespace VerticalSliceArchitecture.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private const string CHECK_ERRORS = "check the errors";

        private readonly IMediator _mediator;

        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAsync(int page, int size)
        {
            return Ok(await _mediator.Send(new GetUserRequest { Page = page, Size = size }));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> FindAsync(Guid id)
        {
            var user = await _mediator.Send(new FindUserRequest { Id = id });

            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserRequest request)
        {
            var userCreated = await _mediator.Send(request);

            if (!userCreated) return BadRequest(CHECK_ERRORS);

            return Created("", request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateUserRequest request)
        {
            var userUpdated = await _mediator.Send(request);

            if (!userUpdated) return BadRequest(CHECK_ERRORS);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var request = new DeleteUserRequest { Id = id };

            var userUpdated = await _mediator.Send(request);

            if (!userUpdated) return BadRequest(CHECK_ERRORS);

            return NoContent();
        }
    }
}
