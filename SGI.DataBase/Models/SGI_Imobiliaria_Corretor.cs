using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imobiliaria_Corretor
    {
        [Key]
        public long COD_CORRETOR { get; set; }
        public int ATIVO { get; set; }
        public long COD_PESSOA { get; set; }
        public long COD_IMOB { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }

        [ForeignKey("COD_IMOB")]
        [InverseProperty("SGI_Imobiliaria_Corretor")]
        public SGI_Imobiliaria COD_IMOBNavigation { get; set; }
        [ForeignKey("COD_PESSOA")]
        [InverseProperty("SGI_Imobiliaria_Corretor")]
        public SGI_Pessoa COD_PESSOANavigation { get; set; }
    }
}
