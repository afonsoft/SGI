using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Imobiliaria
    {
        public long ID { get; set; }
        public long COD_IMOB { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        public bool ATIVO { get; set; }

        public SGI_Imovel COD_ { get; set; }
        [ForeignKey("COD_IMOB")]
        [InverseProperty("SGI_Imovel_Imobiliaria")]
        public SGI_Imobiliaria COD_IMOBNavigation { get; set; }
    }
}
