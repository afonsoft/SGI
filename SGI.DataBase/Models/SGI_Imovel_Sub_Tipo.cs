using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Sub_Tipo
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_SUB_TIPO { get; set; }

        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_Imovel_Sub_Tipo")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
        [ForeignKey("COD_SUB_TIPO")]
        [InverseProperty("SGI_Imovel_Sub_Tipo")]
        public SGI_AUX_Sub_Tipo COD_SUB_TIPONavigation { get; set; }
    }
}
