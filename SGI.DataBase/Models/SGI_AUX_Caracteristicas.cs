using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Caracteristicas
    {
        public SGI_AUX_Caracteristicas()
        {
            SGI_Imovel_Caracteristicas = new HashSet<SGI_Imovel_Caracteristicas>();
        }

        [Key]
        public long COD_CARACTERISTICA { get; set; }
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }

        [InverseProperty("COD_CARACTERISTICANavigation")]
        public ICollection<SGI_Imovel_Caracteristicas> SGI_Imovel_Caracteristicas { get; set; }
    }
}
