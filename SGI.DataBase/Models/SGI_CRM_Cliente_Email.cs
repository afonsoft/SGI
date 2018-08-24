using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Email
    {
        [Key]
        public long COD_EMAIL { get; set; }
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_ENVIO { get; set; }
        [StringLength(155)]
        public string PARA { get; set; }
        [StringLength(255)]
        public string ASSUNTO { get; set; }
        public string CORPO { get; set; }

        public SGI_CRM_Cliente COD_ { get; set; }
    }
}
