using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Acabamentos
    {
        public SGI_AUX_Acabamentos()
        {
            SGI_Imovel_Acabamento = new HashSet<SGI_Imovel_Acabamento>();
        }

        [Key]
        public long COD_ACABAMENTO { get; set; }
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }
        public bool ATIVO { get; set; }

        [InverseProperty("COD_ACABAMENTONavigation")]
        public ICollection<SGI_Imovel_Acabamento> SGI_Imovel_Acabamento { get; set; }
    }
}
