using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_documentos
    {
        [Key]
        public long COD_DOC { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        [StringLength(155)]
        public string DOCUMENTO { get; set; }
        public byte[] BINARIO { get; set; }
        [StringLength(5)]
        public string EXTENSAO { get; set; }
        public long COD_USUARIO { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
