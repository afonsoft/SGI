using SGI.DataBase;
using SGI.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGI.Api.Repository
{
    public class PessoasRepository : RepositoryBase<SGI_Pessoa>
    {
        public PessoasRepository(SgiDbContext context) : base(context) { }
    }
}
