using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Complementar
    {
        public long ID { get; set; }
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Required]
        [StringLength(70)]
        public string NOME_DOCUMENTO { get; set; }
        [Required]
        [StringLength(70)]
        public string VALOR_CODUMENTO { get; set; }
        [StringLength(30)]
        public string CNH { get; set; }

        public SGI_CRM_Cliente COD_ { get; set; }
    }
}
