using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Perfil
    {
        public SGI_Perfil()
        {
            SGI_Usuario_Perfil = new HashSet<SGI_Usuario_Perfil>();
        }

        [Key]
        public long COD_PERFIL { get; set; }
        [Required]
        [StringLength(150)]
        public string NOME_PERFIL { get; set; }
        public int? ORDEM { get; set; }

        [InverseProperty("COD_PERFILNavigation")]
        public ICollection<SGI_Usuario_Perfil> SGI_Usuario_Perfil { get; set; }
    }
}
