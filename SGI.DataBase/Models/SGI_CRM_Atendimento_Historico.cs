using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Atendimento_Historico
    {
        public long ID { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_INTERACAO { get; set; }
        public long ATENDENTE { get; set; }
        public string DESCRICAO { get; set; }
        public bool STATUS { get; set; }
        public int COD_CONTATO { get; set; }

        public SGI_CRM_Atendimento COD_ { get; set; }
    }
}
