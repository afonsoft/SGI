using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Processo_Tipo
    {
        public long ID { get; set; }
        [StringLength(150)]
        public string DESCRICAO { get; set; }
        public int ATIVO { get; set; }
    }
}
