using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Walks.Models.DTO;

namespace DotNetBungieAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> userManager;

    public AuthController(UserManager<IdentityUser> userManager)
    {
        this.userManager = userManager;
    }

    [HttpPost(Name = "Register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        var identityUser = new IdentityUser
        {
            UserName = registerDto.Username,
            Email = registerDto.Username
        };

        var identityResult = await userManager.CreateAsync(identityUser, registerDto.Password);

        if (!identityResult.Succeeded)
        {
            return BadRequest(identityResult.Errors);
        }

        // Add roles to user
        if (registerDto.Roles != null && registerDto.Roles.Any())
        {
            identityResult = await userManager.AddToRolesAsync(identityUser, registerDto.Roles);

            if (!identityResult.Succeeded)
            {
                return BadRequest(identityResult.Errors);
            }

            return Ok("User created and added to role");
        }

        return Ok();
    }
}