using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Propostas
    {
        public SGI_CRM_Cliente_Propostas()
        {
            SGI_CRM_Cliente_Propostas_Historico = new HashSet<SGI_CRM_Cliente_Propostas_Historico>();
        }

        [Key]
        public long COD_PROPOSTA { get; set; }
        public long PROPOSTA_ORIGEM { get; set; }
        public long PROPOSTA_UNIDADE { get; set; }
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_PROPOSTA { get; set; }
        public long COD_IMOVEL { get; set; }
        public long IMOVEL_ORIGEM { get; set; }
        public long IMOVEL_UNIDADE { get; set; }
        public int QTD_VALIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_FINALIZADO { get; set; }
        public bool STATUS { get; set; }

        public SGI_CRM_Cliente COD_ { get; set; }
        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_CRM_Cliente_Propostas")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
        public ICollection<SGI_CRM_Cliente_Propostas_Historico> SGI_CRM_Cliente_Propostas_Historico { get; set; }
    }
}
