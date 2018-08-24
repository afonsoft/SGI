using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_email
    {
        public long ID { get; set; }
        [Required]
        [StringLength(18)]
        public string REFERENCIA { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_HORA { get; set; }
        [Required]
        [StringLength(150)]
        public string EMAIL_ORIGEM { get; set; }
        [Required]
        [StringLength(150)]
        public string EMAIL_DESTINO { get; set; }
        [Required]
        public string OBSERVACAO { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
