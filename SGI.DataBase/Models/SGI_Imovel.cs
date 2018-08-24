using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel
    {
        public SGI_Imovel()
        {
            SGI_CRM_Cliente_Imovel = new HashSet<SGI_CRM_Cliente_Imovel>();
            SGI_CRM_Cliente_Propostas = new HashSet<SGI_CRM_Cliente_Propostas>();
            SGI_Imovel_ADM_Pgto = new HashSet<SGI_Imovel_ADM_Pgto>();
            SGI_Imovel_Acabamento = new HashSet<SGI_Imovel_Acabamento>();
            SGI_Imovel_Auxiliar = new HashSet<SGI_Imovel_Auxiliar>();
            SGI_Imovel_Caracteristicas = new HashSet<SGI_Imovel_Caracteristicas>();
            SGI_Imovel_Caracteristicas_Predio_Casa = new HashSet<SGI_Imovel_Caracteristicas_Predio_Casa>();
            SGI_Imovel_Composicao = new HashSet<SGI_Imovel_Composicao>();
            SGI_Imovel_Fotos = new HashSet<SGI_Imovel_Fotos>();
            SGI_Imovel_Imobiliaria = new HashSet<SGI_Imovel_Imobiliaria>();
            SGI_Imovel_Proprietario = new HashSet<SGI_Imovel_Proprietario>();
            SGI_Imovel_Seo = new HashSet<SGI_Imovel_Seo>();
            SGI_Imovel_Sub_Tipo = new HashSet<SGI_Imovel_Sub_Tipo>();
            SGI_Imovel_Temporada = new HashSet<SGI_Imovel_Temporada>();
            SGI_Imovel_documentos = new HashSet<SGI_Imovel_documentos>();
            SGI_Imovel_email = new HashSet<SGI_Imovel_email>();
        }

        [Key]
        public long COD_IMOVEL { get; set; }
        public long COD_POSICAO { get; set; }
        public long COD_TIPO { get; set; }
        public long COD_ORIGEM { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_CADASTRO { get; set; }
        [Required]
        [StringLength(10)]
        public string VALIDACAO { get; set; }
        public long COD_UNIDADE { get; set; }
        [Required]
        public bool? PUBLICAR { get; set; }
        [Required]
        [StringLength(20)]
        public string REFERENCIA { get; set; }
        [StringLength(20)]
        public string REF_ALTERNATIVA { get; set; }
        public bool STATUS { get; set; }
        [Required]
        [StringLength(16)]
        public string FINALIDADE { get; set; }
        [StringLength(150)]
        public string LOGRADOURO { get; set; }
        [StringLength(10)]
        public string NUMERO { get; set; }
        [StringLength(50)]
        public string APTO { get; set; }
        [StringLength(50)]
        public string EDIFICIO { get; set; }
        [StringLength(18)]
        public string BLOCO { get; set; }
        [StringLength(100)]
        public string BAIRRO { get; set; }
        [StringLength(150)]
        public string CIDADE { get; set; }
        [StringLength(150)]
        public string UF { get; set; }
        [StringLength(11)]
        public string CEP { get; set; }
        [StringLength(18)]
        public string PAVIMENTO { get; set; }
        [StringLength(50)]
        public string REGIAO { get; set; }
        [StringLength(150)]
        public string PONTO_REFERENCIA { get; set; }
        [Required]
        [StringLength(4)]
        public string ANO_CONSTRUCAO { get; set; }
        public double VALOR_VENDA { get; set; }
        public double VALOR_LOCACAO { get; set; }
        public double VALOR_IPTU { get; set; }
        public double VALOR_CONDOMINIO { get; set; }
        [Required]
        [StringLength(7)]
        public string ENTREGA_OBRA { get; set; }
        [StringLength(100)]
        public string LOCAL_CHAVES { get; set; }
        public bool LANCAMENTO { get; set; }
        public bool PRE_LANCAMENTO { get; set; }
        public bool EM_OBRAS { get; set; }
        public bool PRONTO_MORAR { get; set; }
        public bool ESCRITURADO { get; set; }
        public bool REGISTRADO_CARTORIO { get; set; }
        [StringLength(35)]
        public string NOME_CARTORIO { get; set; }
        [StringLength(35)]
        public string MATRICULA_CARTORIO { get; set; }
        [StringLength(50)]
        public string AVERBACAO { get; set; }
        public bool FALTA_AVERBACAO { get; set; }
        public bool INVENTARIO { get; set; }
        public bool USOCAPIAO { get; set; }
        public bool CONTRATO { get; set; }
        public bool LAUDEMIO { get; set; }
        [StringLength(30)]
        public string LANCTO_IPTU { get; set; }
        [StringLength(35)]
        public string ENERGIA { get; set; }
        [StringLength(35)]
        public string GAS { get; set; }
        [StringLength(35)]
        public string AGUA { get; set; }
        public double DIMENSAO_LADO_1 { get; set; }
        public double DIMENSAO_LADO_2 { get; set; }
        public double AREA_UTIL { get; set; }
        public double AREA_TOTAL { get; set; }
        public bool TIROU_FOTOS { get; set; }
        public bool COLOCOU_PLACA { get; set; }
        [StringLength(40)]
        public string INDICADOR { get; set; }
        public string OUTROS_CONTATOS { get; set; }
        public long ORIGEM_CONTATO { get; set; }
        public long MOTIVO_VENDA { get; set; }
        [StringLength(45)]
        public string REGIAO_CONTATO { get; set; }
        [StringLength(45)]
        public string CIDADE_CONTATO { get; set; }
        public int CONTATO_INTERIOR { get; set; }
        public int CONTATO_CAPITAL { get; set; }
        public int CONTATO_LITORAL { get; set; }
        public int NUMERO_MAXIMO_PESSOAS { get; set; }
        public long USUARIO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ALTERADO { get; set; }
        public int QTD_FOTOS { get; set; }
        public bool SGI_REVENDA { get; set; }
        public bool SGI_LANCTO { get; set; }
        [StringLength(30)]
        public string REF_MIGRACAO { get; set; }

        [ForeignKey("COD_POSICAO")]
        [InverseProperty("SGI_Imovel")]
        public SGI_AUX_Posicao COD_POSICAONavigation { get; set; }
        [ForeignKey("COD_TIPO")]
        [InverseProperty("SGI_Imovel")]
        public SGI_AUX_Tipo COD_TIPONavigation { get; set; }
        public SGI_Imovel_Venda SGI_Imovel_Venda { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_CRM_Cliente_Imovel> SGI_CRM_Cliente_Imovel { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_CRM_Cliente_Propostas> SGI_CRM_Cliente_Propostas { get; set; }
        public ICollection<SGI_Imovel_ADM_Pgto> SGI_Imovel_ADM_Pgto { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_Imovel_Acabamento> SGI_Imovel_Acabamento { get; set; }
        public ICollection<SGI_Imovel_Auxiliar> SGI_Imovel_Auxiliar { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_Imovel_Caracteristicas> SGI_Imovel_Caracteristicas { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_Imovel_Caracteristicas_Predio_Casa> SGI_Imovel_Caracteristicas_Predio_Casa { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_Imovel_Composicao> SGI_Imovel_Composicao { get; set; }
        public ICollection<SGI_Imovel_Fotos> SGI_Imovel_Fotos { get; set; }
        public ICollection<SGI_Imovel_Imobiliaria> SGI_Imovel_Imobiliaria { get; set; }
        public ICollection<SGI_Imovel_Proprietario> SGI_Imovel_Proprietario { get; set; }
        public ICollection<SGI_Imovel_Seo> SGI_Imovel_Seo { get; set; }
        [InverseProperty("COD_IMOVELNavigation")]
        public ICollection<SGI_Imovel_Sub_Tipo> SGI_Imovel_Sub_Tipo { get; set; }
        public ICollection<SGI_Imovel_Temporada> SGI_Imovel_Temporada { get; set; }
        public ICollection<SGI_Imovel_documentos> SGI_Imovel_documentos { get; set; }
        public ICollection<SGI_Imovel_email> SGI_Imovel_email { get; set; }
    }
}
