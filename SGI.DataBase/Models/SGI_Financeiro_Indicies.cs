using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Financeiro_Indicies
    {
        public long ID { get; set; }
        [StringLength(20)]
        public string SIGLA { get; set; }
        [StringLength(200)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }
    }
}
