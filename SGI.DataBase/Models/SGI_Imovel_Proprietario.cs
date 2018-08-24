using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Proprietario
    {
        public long ID { get; set; }
        public long COD_PESSOA { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        public bool INVESTIDOR { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_ALTERACAO { get; set; }

        public SGI_Imovel COD_ { get; set; }
        [ForeignKey("COD_PESSOA")]
        [InverseProperty("SGI_Imovel_Proprietario")]
        public SGI_Pessoa COD_PESSOANavigation { get; set; }
    }
}
