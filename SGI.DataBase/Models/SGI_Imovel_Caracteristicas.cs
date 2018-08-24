using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Caracteristicas
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_CARACTERISTICA { get; set; }

        [ForeignKey("COD_CARACTERISTICA")]
        [InverseProperty("SGI_Imovel_Caracteristicas")]
        public SGI_AUX_Caracteristicas COD_CARACTERISTICANavigation { get; set; }
        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_Imovel_Caracteristicas")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
    }
}
