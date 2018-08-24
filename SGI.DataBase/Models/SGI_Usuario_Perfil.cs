using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Usuario_Perfil
    {
        public long ID { get; set; }
        public long COD_PERFIL { get; set; }
        public long COD_USUARIO { get; set; }

        [ForeignKey("COD_PERFIL")]
        [InverseProperty("SGI_Usuario_Perfil")]
        public SGI_Perfil COD_PERFILNavigation { get; set; }
        [ForeignKey("COD_USUARIO")]
        [InverseProperty("SGI_Usuario_Perfil")]
        public SGI_Usuarios COD_USUARIONavigation { get; set; }
    }
}
