using Microsoft.EntityFrameworkCore;
using SGI.Api.Interfaces;
using SGI.DataBase;
using SGI.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SGI.Api.Repository
{
    public class UsersRepository : RepositoryBase<SGI_Usuarios>
    {
        public UsersRepository(SgiDbContext context) : base(context) { }

        public SGI_Usuarios Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            return context.Set<SGI_Usuarios>().FirstOrDefault(x => x.USER_NAME == username && x.SENHA == password);
        }

        public string Claim(ClaimsPrincipal currentUser, string type)
        {
            if (currentUser.HasClaim(c => c.Type == type))
            {
                return currentUser.Claims.FirstOrDefault(c => c.Type == type).Value;
            }

            return "";
        }

    }
}
