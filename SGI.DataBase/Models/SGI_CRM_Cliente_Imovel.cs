using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente_Imovel
    {
        public long ID { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Required]
        [StringLength(80)]
        public string IMOVEL_REFERENCIA { get; set; }
        public long COD_IMOVEL { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }

        public SGI_CRM_Atendimento COD_ { get; set; }
        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_CRM_Cliente_Imovel")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
    }
}
