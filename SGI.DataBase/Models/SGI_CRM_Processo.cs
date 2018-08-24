using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Processo
    {
        [Key]
        public long COD_PROCESSO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public long COD_CLIENTE { get; set; }
        public int TIPO_PROCESSO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_INICIO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_FINAL { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public bool STATUS { get; set; }

        public SGI_CRM_Atendimento COD_ { get; set; }
        public SGI_CRM_Cliente COD_Navigation { get; set; }
    }
}
