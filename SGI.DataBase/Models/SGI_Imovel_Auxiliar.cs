using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Auxiliar
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public bool DESOCUPADO { get; set; }
        public bool COM_MORADOR { get; set; }
        public bool COM_INQUILINO { get; set; }
        public bool CONTRATO_EXCLUSIVIDADE { get; set; }
        [Required]
        [StringLength(30)]
        public string DIAS_EXCLUSIVIDADE { get; set; }
        public int TABELA_CONSTRUTOR { get; set; }
        [Required]
        [StringLength(20)]
        public string DISTANCIA_PRAIA { get; set; }
        [Required]
        [StringLength(20)]
        public string DISTANCIA_CENTRO { get; set; }
        [Required]
        [StringLength(20)]
        public string DISTANCIA_METRO { get; set; }
        public long CONSERVACAO { get; set; }
        public bool ACEITA_PERMUTA { get; set; }
        public bool NAO_ACEITA_PERMUTA { get; set; }
        public int MAIOR_VALOR { get; set; }
        public int MENOR_VALOR { get; set; }
        public bool AUTO { get; set; }
        public bool CASA { get; set; }
        public bool APTO { get; set; }
        public bool TERRENO { get; set; }
        [StringLength(100)]
        public string REGIAO { get; set; }
        [StringLength(100)]
        public string CIDADE { get; set; }
        public string OBS_PERMUTA { get; set; }
        public bool FIADOR { get; set; }
        public bool ESCRITURA_FIADOR { get; set; }
        public bool SEGURO_FIANCA { get; set; }
        public bool DEPOSITO { get; set; }
        public int DEPOSITO_MESES { get; set; }
        public int ADM_LOCACAO { get; set; }
        public string OBS_LOCACAO { get; set; }
        public int NUMERO_DIAS { get; set; }
        public string DIAS_RESERVADOS { get; set; }
        public bool FINANCIAMENTO_BANCARIO { get; set; }
        public int MCMV { get; set; }
        public bool FINANCIAMENTO_DIRETO { get; set; }
        public double VALOR_ENTRADA { get; set; }
        public int QTD_MENSAIS { get; set; }
        public double VALOR_MENSAIS { get; set; }
        public double VALOR_CHAVES { get; set; }
        public int QTD_TRIMESTRAIS { get; set; }
        public double VALOR_TRIMESTRAIS { get; set; }
        public int QTD_SEMESTRAIS { get; set; }
        public double VALOR_SEMESTRAIS { get; set; }
        public int QTD_ANUAIS { get; set; }
        public double VALOR_ANUAIS { get; set; }
        public int SIGLA_INDICE_DURANTE { get; set; }
        public double FATOR_DURANTE { get; set; }
        public int SIGLA_INDICE_APOS { get; set; }
        public double FATOR_APOS { get; set; }
        public double VALOR_A_VISTA { get; set; }
        public double VALOR_COMPRA { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
