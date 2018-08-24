using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_ADM_Forma_Pgto
    {
        public long ID { get; set; }
        [StringLength(100)]
        public string DESCRICAO { get; set; }
        [Required]
        public bool? ATIVO { get; set; }
    }
}
