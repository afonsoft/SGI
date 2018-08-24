using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Acabamento
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ACABAMENTO { get; set; }

        [ForeignKey("COD_ACABAMENTO")]
        [InverseProperty("SGI_Imovel_Acabamento")]
        public SGI_AUX_Acabamentos COD_ACABAMENTONavigation { get; set; }
        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_Imovel_Acabamento")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
    }
}
