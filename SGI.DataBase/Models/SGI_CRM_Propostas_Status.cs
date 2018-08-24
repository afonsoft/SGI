using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Propostas_Status
    {
        public long ID { get; set; }
        [StringLength(150)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }
    }
}
