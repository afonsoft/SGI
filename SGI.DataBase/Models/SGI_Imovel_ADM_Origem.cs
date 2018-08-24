using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_ADM_Origem
    {
        public long ID { get; set; }
        [StringLength(150)]
        public string DESCRICAO { get; set; }
        [Required]
        public bool? ATIVO { get; set; }
    }
}
