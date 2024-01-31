using Business.Abstract;
using Business.Requests.User;
using Business.Responses.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet] // Get
        public GetUserListResponse GetList([FromQuery] GetUserListRequest request)
        {
            GetUserListResponse response = _userService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // Get
        public GetUserByIdResponse GetById([FromRoute] GetUserByIdRequest request)
        {
            GetUserByIdResponse response = _userService.GetById(request);
            return response;
        }

        [HttpPost] // Post
        public ActionResult<AddUserResponse> Add(AddUserRequest request)
        {
            AddUserResponse response = _userService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id },
                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // Put 
        public ActionResult<UpdateUserResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateUserRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateUserResponse response = _userService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // Delete
        public DeleteUserResponse Delete([FromRoute] DeleteUserRequest request)
        {
            DeleteUserResponse response = _userService.Delete(request);
            return response;
        }
    }
}
