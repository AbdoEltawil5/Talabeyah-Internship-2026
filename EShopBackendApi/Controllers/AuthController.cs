using Application.Models;
using Application.Services;
using EShopBackendApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EShopBackendApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly JwtTokenHelper _jwtTokenHelper;

    public AuthController(IUserService userService, JwtTokenHelper jwtTokenHelper)
    {
        _userService = userService;
        _jwtTokenHelper = jwtTokenHelper;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] CredentialsRequest request)
    {
        try
        {
            var user = await _userService.LoginAsync(request);
            var token = _jwtTokenHelper.GenerateToken(user);
            return Ok(token);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (UnauthorizedAccessException)
        {
            return Unauthorized(new { message = "Invalid email or password." });
        }
    }
}
