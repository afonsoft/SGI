using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Composicao
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_COMPOSICAO { get; set; }
        public int QUANTIDADE { get; set; }

        [ForeignKey("COD_COMPOSICAO")]
        [InverseProperty("SGI_Imovel_Composicao")]
        public SGI_AUX_Composicao COD_COMPOSICAONavigation { get; set; }
        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_Imovel_Composicao")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
    }
}
