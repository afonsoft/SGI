using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Tipo
    {
        public SGI_AUX_Tipo()
        {
            SGI_Imovel = new HashSet<SGI_Imovel>();
        }

        [Key]
        public long COD_TIPO { get; set; }
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }
        public int ATIVO { get; set; }

        [InverseProperty("COD_TIPONavigation")]
        public ICollection<SGI_Imovel> SGI_Imovel { get; set; }
    }
}
