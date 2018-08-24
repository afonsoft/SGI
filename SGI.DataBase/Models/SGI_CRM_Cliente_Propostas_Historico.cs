using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Propostas_Historico
    {
        public long ID { get; set; }
        public long COD_PROPOSTA { get; set; }
        public long PROPOSTA_ORIGEM { get; set; }
        public long PROPOSTA_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }
        public string FILE_NAME { get; set; }
        public int VERSAO { get; set; }

        public SGI_CRM_Cliente_Propostas SGI_CRM_Cliente_Propostas { get; set; }
    }
}
