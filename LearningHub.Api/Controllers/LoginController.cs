using LearningHub.Core.Data;
using LearningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Authh(Userlogin login)
        {
            var token = _loginService.Authh(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }


        }
    }
}
