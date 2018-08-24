using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SGI.Api.Models;
using SGI.Api.Repository;
using SGI.DataBase;
using SGI.DataBase.Models;

namespace SGI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly SgiDbContext context;
        private readonly UsersRepository usersRepository;
        private readonly PessoasRepository pessoasRepository;

        private readonly ILogger logger;
        private readonly Settings settings;

        public UsersController(SgiDbContext context, IOptions<Settings> settings, ILoggerFactory loggerFactory)
        {
            this.context = context;
            this.logger = loggerFactory.CreateLogger<UsersController>();
            this.settings = settings.Value;
            usersRepository = new UsersRepository(context);
            pessoasRepository = new PessoasRepository(context);
        }

        [HttpGet]
        public ActionResult<SGI_Pessoa> Get()
        {

            var currentUser = HttpContext.User;

            string cod = usersRepository.Claim(currentUser, ClaimTypes.Sid);

            if (!string.IsNullOrEmpty(cod))
            {
                SGI_Pessoa pessoa = pessoasRepository.GetById(long.Parse(cod));

                //SGI_Pessoa pessoa = pessoasRepository.dbSet.Include(x => x.SGI_Imobiliaria_Corretor)
                //                                           .Include(x => x.SGI_Imovel_Proprietario)
                //                                           .Include(x => x.SGI_Usuarios)
                //                                           .FirstOrDefault(x => x.COD_PESSOA == long.Parse(cod));

                //pessoa.SGI_Imobiliaria_Corretor
                //pessoa.SGI_Imovel_Proprietario
                //pessoa.SGI_Usuarios

                if (pessoa != null)
                {
                    return  Ok(pessoa);
                }
            }

            return NotFound();
        }
    }
}