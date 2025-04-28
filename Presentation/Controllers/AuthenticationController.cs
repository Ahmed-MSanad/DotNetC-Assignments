using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;
using Shared.IdentityDtos;

namespace Presentation.Controllers
{
    public class AuthenticationController(IServiceManager serviceManager) : ApiController
    {
        [HttpPost("Login")]
        public async Task<ActionResult<UserResultDto>> login(LoginDto loginDto)
            => Ok(await serviceManager.AuthenticationService.LoginAsync(loginDto));

        [HttpPost("Register")]
        public async Task<ActionResult<UserResultDto>> Register(RegisterDto registerDto)
            => Ok(await serviceManager.AuthenticationService.RegisterAsync(registerDto));
    }
}
