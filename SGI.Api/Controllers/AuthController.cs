using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SGI.Api.Models;
using SGI.Api.Repository;
using SGI.DataBase;
using SGI.DataBase.Models;

namespace SGI.Api.Controllers
{
    //https://auth0.com/blog/securing-asp-dot-net-core-2-applications-with-jwts/

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly SgiDbContext context;
        private readonly UsersRepository usersRepository;
        private readonly PessoasRepository pessoasRepository;

        private readonly ILogger logger;
        private readonly Settings settings;
        
        public AuthController(SgiDbContext context, IOptions<Settings> settings, ILoggerFactory loggerFactory)
        {
            this.context = context;
            this.logger = loggerFactory.CreateLogger<AuthController>();
            this.settings = settings.Value;
            usersRepository = new UsersRepository(context);
            pessoasRepository = new PessoasRepository(context);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody]Login login)
        {
            IActionResult response = Unauthorized();
            var user = Valid(login);
            if (user != null)
            {
                var tokenString = BuildToken(user);

                if (string.IsNullOrEmpty(tokenString))
                    return response;

                response = Ok(new { scheme = "bearer", login = login.Username, expires = DateTime.Now.AddMinutes(30), token = tokenString });
            }

            return response;
        }

        private SGI_Usuarios Valid(Login login)
        {
            if (login == null)
                return null;

            return usersRepository.Login(login.Username, login.Password);
        }

        private string BuildToken(SGI_Usuarios user)
        {
            if (user == null)
                return "";

            SGI_Pessoa pessoa = pessoasRepository.Get(x => x.COD_PESSOA == user.COD_PESSOA).FirstOrDefault();

            if (pessoa == null)
                return "";

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Token.Key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, pessoa.NOME),
                new Claim(ClaimTypes.Email, user.USER_EMAIL),
                new Claim(ClaimTypes.Sid, pessoa.COD_PESSOA.ToString()),
                new Claim(ClaimTypes.WindowsAccountName, user.USER_NAME),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.USER_NAME),
                new Claim(ClaimTypes.DateOfBirth, (pessoa.ANIVERSARIO.HasValue ? pessoa.ANIVERSARIO.Value.ToString("u"): DateTime.Now.ToString("u")))
            };

            var tokeOptions = new JwtSecurityToken(
                issuer: settings.Token.Issuer,
                audience: settings.Token.Issuer,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokeOptions);

        }
    }
}
