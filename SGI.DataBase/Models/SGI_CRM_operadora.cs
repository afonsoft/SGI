using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_operadora
    {
        [Key]
        public long COD_OPERADORA { get; set; }
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }
    }
}
