using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Sub_Tipo
    {
        public SGI_AUX_Sub_Tipo()
        {
            SGI_Imovel_Sub_Tipo = new HashSet<SGI_Imovel_Sub_Tipo>();
        }

        [Key]
        public long COD_SUB_TIPO { get; set; }
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }
        public int ORDEM { get; set; }
        public long TIPO { get; set; }
        public bool ATIVO { get; set; }

        [InverseProperty("COD_SUB_TIPONavigation")]
        public ICollection<SGI_Imovel_Sub_Tipo> SGI_Imovel_Sub_Tipo { get; set; }
    }
}
