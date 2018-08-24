using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Agenda
    {
        public long ID { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }
        public long ATENDENTE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_RETORNO { get; set; }
        public bool STATUS { get; set; }
        public int TIPO_RETORNO { get; set; }

        public SGI_CRM_Atendimento COD_ { get; set; }
    }
}
