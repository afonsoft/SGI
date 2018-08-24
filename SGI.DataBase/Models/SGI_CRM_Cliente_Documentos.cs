using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Documentos
    {
        [Key]
        public long COD_DOCUMENTO { get; set; }
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Required]
        [StringLength(200)]
        public string DESCRICAO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }
        public bool ENVIADO { get; set; }
        public byte[] ANEXO { get; set; }

        public SGI_CRM_Cliente COD_ { get; set; }
    }
}
