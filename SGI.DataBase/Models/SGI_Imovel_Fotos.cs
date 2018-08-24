using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Fotos
    {
        [Key]
        public long COD_FOTO { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public double TAMANHO { get; set; }
        [Required]
        [StringLength(20)]
        public string NOME { get; set; }
        [Required]
        [StringLength(150)]
        public string ENDERECO { get; set; }
        [Required]
        public byte[] BINARIO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }
        public bool DESTAQUE { get; set; }
        [Required]
        public bool? EXIBIR { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
