using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Usuarios
    {
        public SGI_Usuarios()
        {
            SGI_Usuario_Perfil = new HashSet<SGI_Usuario_Perfil>();
        }

        [Key]
        public long COD_USUARIO { get; set; }
        public long COD_PESSOA { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        [Required]
        [StringLength(30)]
        public string USER_NAME { get; set; }
        [Required]
        [StringLength(30)]
        public string SENHA { get; set; }
        [Required]
        [StringLength(150)]
        public string USER_EMAIL { get; set; }
        public int ATIVO { get; set; }

        [ForeignKey("COD_PESSOA")]
        [InverseProperty("SGI_Usuarios")]
        public SGI_Pessoa COD_PESSOANavigation { get; set; }
        [InverseProperty("COD_USUARIONavigation")]
        public ICollection<SGI_Usuario_Perfil> SGI_Usuario_Perfil { get; set; }
    }
}
