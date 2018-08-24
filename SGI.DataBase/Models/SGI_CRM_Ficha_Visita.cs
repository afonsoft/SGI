using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Ficha_Visita
    {
        public SGI_CRM_Ficha_Visita()
        {
            SGI_CRM_Ficha_Imovel = new HashSet<SGI_CRM_Ficha_Imovel>();
        }

        [Key]
        public long COD_FICHA { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_IMPRESSAO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_VISITA { get; set; }
        public long COD_CLIENTE { get; set; }
        public long CLIENTE_ORIGEM { get; set; }
        public long CLIENTE_UNIDADE { get; set; }
        public bool IMPRESSO { get; set; }

        public SGI_CRM_Atendimento COD_ { get; set; }
        public ICollection<SGI_CRM_Ficha_Imovel> SGI_CRM_Ficha_Imovel { get; set; }
    }
}
