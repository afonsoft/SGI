using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imobiliaria
    {
        public SGI_Imobiliaria()
        {
            SGI_Imobiliaria_Corretor = new HashSet<SGI_Imobiliaria_Corretor>();
            SGI_Imobiliaria_Filial = new HashSet<SGI_Imobiliaria_Filial>();
            SGI_Imobiliaria_Imagens = new HashSet<SGI_Imobiliaria_Imagens>();
            SGI_Imovel_Imobiliaria = new HashSet<SGI_Imovel_Imobiliaria>();
        }

        [Key]
        public long COD_IMOB { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_ATIVACAO { get; set; }
        public long FILIAL { get; set; }
        public int INVESTIDOR { get; set; }
        public int ENVIAR_TABELAS { get; set; }
        [Required]
        [StringLength(80)]
        public string NOME_IMOB { get; set; }
        [StringLength(80)]
        public string RESPONSAVEL { get; set; }
        [Required]
        [StringLength(18)]
        public string CPF { get; set; }
        [Required]
        [StringLength(21)]
        public string CNPJ { get; set; }
        [StringLength(20)]
        public string CRECI { get; set; }
        [Required]
        [StringLength(10)]
        public string VALIDACAO { get; set; }
        [StringLength(150)]
        public string ENDERECO { get; set; }
        [StringLength(10)]
        public string NUMERO { get; set; }
        [StringLength(50)]
        public string COPLEMENTO { get; set; }
        [StringLength(100)]
        public string BAIRRO { get; set; }
        [StringLength(150)]
        public string CIDADE { get; set; }
        [StringLength(11)]
        public string CEP { get; set; }
        [StringLength(2)]
        public string UF { get; set; }
        [Required]
        [StringLength(18)]
        public string TELEFONE_01 { get; set; }
        [Required]
        [StringLength(18)]
        public string TELEFONE_02 { get; set; }
        [Required]
        [StringLength(18)]
        public string CELULAR_01 { get; set; }
        [Required]
        [StringLength(18)]
        public string CELULAR_02 { get; set; }
        [Required]
        [StringLength(18)]
        public string WHATSAPP { get; set; }
        [StringLength(25)]
        public string NEXTEL_ID { get; set; }
        [StringLength(150)]
        public string EMAIL_PRINCIPAL { get; set; }
        [StringLength(150)]
        public string EMAIL_SITE { get; set; }
        [StringLength(200)]
        public string URL_01 { get; set; }
        [StringLength(200)]
        public string URL_02 { get; set; }
        [StringLength(200)]
        public string FACEBOOK { get; set; }
        [StringLength(200)]
        public string LINKEDIN { get; set; }

        [InverseProperty("COD_IMOBNavigation")]
        public SGI_Imobiliaria_conf SGI_Imobiliaria_conf { get; set; }
        [InverseProperty("COD_IMOBNavigation")]
        public ICollection<SGI_Imobiliaria_Corretor> SGI_Imobiliaria_Corretor { get; set; }
        [InverseProperty("COD_IMOBNavigation")]
        public ICollection<SGI_Imobiliaria_Filial> SGI_Imobiliaria_Filial { get; set; }
        [InverseProperty("COD_IMOBNavigation")]
        public ICollection<SGI_Imobiliaria_Imagens> SGI_Imobiliaria_Imagens { get; set; }
        [InverseProperty("COD_IMOBNavigation")]
        public ICollection<SGI_Imovel_Imobiliaria> SGI_Imovel_Imobiliaria { get; set; }
    }
}
