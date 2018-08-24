using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_AUX_Composicao
    {
        public SGI_AUX_Composicao()
        {
            SGI_Imovel_Composicao = new HashSet<SGI_Imovel_Composicao>();
        }

        [Key]
        public long COD_COMPOSICAO { get; set; }
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }
        public int ORDEM { get; set; }
        public bool ATIVO { get; set; }
        public long TIPO { get; set; }

        [InverseProperty("COD_COMPOSICAONavigation")]
        public ICollection<SGI_Imovel_Composicao> SGI_Imovel_Composicao { get; set; }
    }
}
