using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Conservacao
    {
        [Key]
        public long COD_CONSERVACAO { get; set; }
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }
    }
}
