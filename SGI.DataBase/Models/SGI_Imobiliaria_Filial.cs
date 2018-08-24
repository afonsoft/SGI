using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imobiliaria_Filial
    {
        [Key]
        public long COD_FILIAL { get; set; }
        public long COD_IMOB { get; set; }
        [Required]
        [StringLength(50)]
        public string DESCRICAO_FILIAL { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_ATIVACAO { get; set; }
        public int INVESTIDOR { get; set; }
        public int ENVIAR_TABELAS { get; set; }
        [Required]
        [StringLength(45)]
        public string NOME_IMOB { get; set; }
        [StringLength(45)]
        public string RESPONSAVEL { get; set; }
        [Required]
        [StringLength(18)]
        public string CPF { get; set; }
        [Required]
        [StringLength(18)]
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
        [StringLength(150)]
        public string EMAIL_PRINCIPAL { get; set; }
        [StringLength(150)]
        public string EMAIL_SITE { get; set; }
        [StringLength(200)]
        public string URL_01 { get; set; }
        [StringLength(200)]
        public string URL_02 { get; set; }

        [ForeignKey("COD_IMOB")]
        [InverseProperty("SGI_Imobiliaria_Filial")]
        public SGI_Imobiliaria COD_IMOBNavigation { get; set; }
    }
}
