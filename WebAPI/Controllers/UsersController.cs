using Azure.Core;
using Business.Abstract;
using Business.Requests.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Core.Utilities.Security.JWT;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Register")]
    public void Register([FromBody] Business.Requests.User.RegisterRequest request)
    {
        _userService.Register(request);
    }
    [HttpPost("Login")]
    public AccessToken Login([FromBody] LoginRequest request)
    {
        return _userService.Login(request);
    }


}
