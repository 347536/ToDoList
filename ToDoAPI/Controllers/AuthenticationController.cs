using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using ToDoOrganize.Models.Dtos.Users.Requests;
using ToDoOrganize.Service.Abstracts;
using ToDoOrganize.API.Controllers;
using ToDoOrganize.Models.Dtos.Users.Requests;

using Microsoft.AspNetCore.Mvc;

namespace ToDoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : CustomBaseController
{
    private readonly ToDoOrganize.Service.Abstracts.IAuthenticationService authenticationService;

    public AuthenticationController(ToDoOrganize.Service.Abstracts.IAuthenticationService authenticationService)
    {
        authenticationService = authenticationService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto dto)
    {
        var result = await authenticationService.LoginAsync(dto);
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto dto)
    {
        var result = await authenticationService.RegisterAsync(dto);
        return Ok(result);
    }
}