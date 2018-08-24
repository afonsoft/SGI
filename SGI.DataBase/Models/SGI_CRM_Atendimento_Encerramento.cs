using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Atendimento_Encerramento
    {
        public long ID { get; set; }
        [StringLength(50)]
        public string DESCRICAO { get; set; }
        [Required]
        public bool? ATIVO { get; set; }
    }
}
