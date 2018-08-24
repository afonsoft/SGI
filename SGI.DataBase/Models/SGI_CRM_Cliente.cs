using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Cliente
    {
        public SGI_CRM_Cliente()
        {
            SGI_CRM_Atendimento = new HashSet<SGI_CRM_Atendimento>();
            SGI_CRM_Cliente_Complementar = new HashSet<SGI_CRM_Cliente_Complementar>();
            SGI_CRM_Cliente_Documentos = new HashSet<SGI_CRM_Cliente_Documentos>();
            SGI_CRM_Cliente_Email = new HashSet<SGI_CRM_Cliente_Email>();
            SGI_CRM_Cliente_Propostas = new HashSet<SGI_CRM_Cliente_Propostas>();
            SGI_CRM_Processo = new HashSet<SGI_CRM_Processo>();
        }

        [Key]
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_CADASTRO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ALTERADO { get; set; }
        public int TIPO { get; set; }
        [StringLength(150)]
        public string NOME { get; set; }
        [StringLength(18)]
        public string TELEFONE_RESIDENCIAL { get; set; }
        [StringLength(18)]
        public string CELULAR { get; set; }
        public int COD_OPERADORA { get; set; }
        [StringLength(18)]
        public string TEL_COMERCIAL { get; set; }
        [StringLength(25)]
        public string NEXTEL_ID { get; set; }
        [StringLength(150)]
        public string EMAIL { get; set; }
        public bool INVESTIDOR { get; set; }
        public bool COMPROU_ANTES { get; set; }
        public string OBS { get; set; }
        public int COD_PESSOA { get; set; }
        public int EXPECTATIVA { get; set; }
        public string RECADO_CORRETOR { get; set; }
        public int CONTATO_ORIGEM { get; set; }
        public int MOTIVO_COMPRA { get; set; }
        [StringLength(150)]
        public string REGIAO { get; set; }
        [StringLength(150)]
        public string CIDADE { get; set; }
        public bool INTERIOR { get; set; }
        public bool CAPITAL { get; set; }
        public bool LITORAL { get; set; }
        public bool PROCURA_COMPRAR { get; set; }
        public bool PROCURA_ALUGAR { get; set; }
        public bool PROCURA_TEMPORADA { get; set; }
        public int TIPO_IMOVEL { get; set; }
        [StringLength(150)]
        public string IMOVEL_CIDADE { get; set; }
        [StringLength(150)]
        public string IMOVEL_BAIRRO { get; set; }
        public int IMOVEL_DORMS { get; set; }
        public int IMOVEL_SUITES { get; set; }
        public int IMOVEL_VAGAS { get; set; }
        public double VALOR_MAXIMO { get; set; }
        public double AREA_UTIL_MINIMA { get; set; }
        public string IMOVEL_RUAS { get; set; }
        public string IMOVEL_EDIFICIO { get; set; }
        public bool DESEJA_FINANCIAR { get; set; }
        public bool DESEJA_LANCAMENTO { get; set; }
        public double VALOR_MAX_ENTRADA { get; set; }
        public double VALOR_MAX_CONDOMINIO { get; set; }
        [Required]
        [StringLength(7)]
        public string ANO_ENTREGA_OBRA { get; set; }
        [StringLength(20)]
        public string MES_ENTREGA_OBRA { get; set; }
        public int RADAR { get; set; }

        public ICollection<SGI_CRM_Atendimento> SGI_CRM_Atendimento { get; set; }
        public ICollection<SGI_CRM_Cliente_Complementar> SGI_CRM_Cliente_Complementar { get; set; }
        public ICollection<SGI_CRM_Cliente_Documentos> SGI_CRM_Cliente_Documentos { get; set; }
        public ICollection<SGI_CRM_Cliente_Email> SGI_CRM_Cliente_Email { get; set; }
        public ICollection<SGI_CRM_Cliente_Propostas> SGI_CRM_Cliente_Propostas { get; set; }
        public ICollection<SGI_CRM_Processo> SGI_CRM_Processo { get; set; }
    }
}
