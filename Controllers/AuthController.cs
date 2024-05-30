using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Walks.Models.DTO;
using Walks.Repositories;

namespace DotNetBungieAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> userManager;
    private readonly ITokenRepository tokenRepository;

    public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
    {
        this.userManager = userManager;
        this.tokenRepository = tokenRepository;
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

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        var identityUser = await userManager.FindByEmailAsync(loginDto.Username);

        if (identityUser != null)
        {
            var checkPasswordResult = await userManager.CheckPasswordAsync(identityUser, loginDto.Password);

            if (checkPasswordResult)
            {
                // Get roles
                var roles = await userManager.GetRolesAsync(identityUser);

                if (roles != null)
                {
                    // Generate JWT
                    var jwtToken = tokenRepository.CreateJWTToken(identityUser, roles.ToList());
                    // In cases we need to return more information
                    var response = new LoginResponseDto
                    {
                        JwtToken = jwtToken
                    };

                    return Ok(response);
                }

            }
        }

        return BadRequest("Invalid username or password");
    }
}