﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ToDoList.Models.Dtos.Users.Requests;
using ToDoList.Service.Abstracts;
using ToDoList.Service.Abstracts;


namespace ToDoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService _userService) : ControllerBase
{
    [HttpGet("email")]
    [Authorize(Roles = "Admin")]

    public async Task<IActionResult> GetByEmail([FromQuery] string email)
    {
        var result = await _userService.GetByEmailAsync(email);
        return Ok(result);
    }
}