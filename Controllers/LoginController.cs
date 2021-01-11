using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Annexus_API.Models;
using Annexus_API.UserServices;
using Annexus_API.UserRepository;
using System.Threading.Tasks;
using System;

namespace Annexus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model)
        {
            var user = userRepository.Get(model.UserName, model.UserPass);
            if(user == null)
            {
                return NotFound(new { message = "Usuario ou senha invalidos." });
            }

            var token = TokenService.GenerateToken(user);
            user.UserPass = "";

            return new { user = user, token = token };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Usuário {0} Autenticado.", User.Identity.Name);

    }
}
