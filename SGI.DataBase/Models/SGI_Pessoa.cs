using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Pessoa
    {
        public SGI_Pessoa()
        {
            SGI_Imobiliaria_Corretor = new HashSet<SGI_Imobiliaria_Corretor>();
            SGI_Imovel_Proprietario = new HashSet<SGI_Imovel_Proprietario>();
            SGI_Usuarios = new HashSet<SGI_Usuarios>();
        }

        [Key]
        public long COD_PESSOA { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_ALTERADO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ANIVERSARIO { get; set; }
        public int TIPO { get; set; }
        [Required]
        [StringLength(80)]
        public string NOME { get; set; }
        [StringLength(60)]
        public string FANTASIA { get; set; }
        [Required]
        [StringLength(150)]
        public string ENDERECO { get; set; }
        [StringLength(20)]
        public string NUMERO { get; set; }
        [StringLength(50)]
        public string COMPLEMENTO { get; set; }
        [StringLength(50)]
        public string REFERENCIA { get; set; }
        [Required]
        [StringLength(80)]
        public string BAIRRO { get; set; }
        [Required]
        [StringLength(80)]
        public string CIDADE { get; set; }
        [Required]
        [StringLength(2)]
        public string UF { get; set; }
        [Required]
        [StringLength(15)]
        public string CEP { get; set; }
        [Required]
        [StringLength(20)]
        public string CNPJCPF { get; set; }
        [StringLength(20)]
        public string IERG { get; set; }
        [StringLength(20)]
        public string TEL_RESISENCIAL { get; set; }
        [StringLength(20)]
        public string TEL_COMERCIAL { get; set; }
        [StringLength(20)]
        public string CELULAR_01 { get; set; }
        [StringLength(20)]
        public string CELULAR_02 { get; set; }
        [StringLength(20)]
        public string WHATSAPP { get; set; }
        [Required]
        [StringLength(20)]
        public string NEXTEL { get; set; }
        [StringLength(80)]
        public string EMAIL_01 { get; set; }
        [StringLength(80)]
        public string EMAIL_02 { get; set; }
        public string OBS { get; set; }
        public int ATIVO { get; set; }
        [Required]
        public bool? CORRETOR { get; set; }
        [StringLength(80)]
        public string CRECI { get; set; }

        [InverseProperty("COD_PESSOANavigation")]
        public ICollection<SGI_Imobiliaria_Corretor> SGI_Imobiliaria_Corretor { get; set; }
        [InverseProperty("COD_PESSOANavigation")]
        public ICollection<SGI_Imovel_Proprietario> SGI_Imovel_Proprietario { get; set; }
        [InverseProperty("COD_PESSOANavigation")]
        public ICollection<SGI_Usuarios> SGI_Usuarios { get; set; }
    }
}
