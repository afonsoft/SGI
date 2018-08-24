using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Caracteristicas_Predio_Casa
    {
        public SGI_AUX_Caracteristicas_Predio_Casa()
        {
            SGI_Imovel_Caracteristicas_Predio_Casa = new HashSet<SGI_Imovel_Caracteristicas_Predio_Casa>();
        }

        [Key]
        public long COD_PREDIO_CASA { get; set; }
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }

        [InverseProperty("COD_PREDIO_CASANavigation")]
        public ICollection<SGI_Imovel_Caracteristicas_Predio_Casa> SGI_Imovel_Caracteristicas_Predio_Casa { get; set; }
    }
}
