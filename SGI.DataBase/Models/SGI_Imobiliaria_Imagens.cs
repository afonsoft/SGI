using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imobiliaria_Imagens
    {
        public long ID { get; set; }
        public long COD_IMOB { get; set; }
        public byte[] LOGO { get; set; }
        public int POSICAO { get; set; }

        [ForeignKey("COD_IMOB")]
        [InverseProperty("SGI_Imobiliaria_Imagens")]
        public SGI_Imobiliaria COD_IMOBNavigation { get; set; }
    }
}
