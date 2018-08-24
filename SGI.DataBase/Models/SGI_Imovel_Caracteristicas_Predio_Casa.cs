using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Caracteristicas_Predio_Casa
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_PREDIO_CASA { get; set; }

        [ForeignKey("COD_IMOVEL")]
        [InverseProperty("SGI_Imovel_Caracteristicas_Predio_Casa")]
        public SGI_Imovel COD_IMOVELNavigation { get; set; }
        [ForeignKey("COD_PREDIO_CASA")]
        [InverseProperty("SGI_Imovel_Caracteristicas_Predio_Casa")]
        public SGI_AUX_Caracteristicas_Predio_Casa COD_PREDIO_CASANavigation { get; set; }
    }
}
