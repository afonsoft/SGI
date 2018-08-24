using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Seo
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public int MOSTRAR_MAPA_SITE { get; set; }
        public int MOSTRAR_END_SITE { get; set; }
        public int DESTAQUE_SITE { get; set; }
        public int DESTAQUE_BANNER { get; set; }
        public int OPORTUNIDADE { get; set; }
        public int PAINEL_TV { get; set; }
        [Required]
        [StringLength(20)]
        public string LATITUDE { get; set; }
        [Required]
        [StringLength(20)]
        public string LONGITUDE { get; set; }
        public string TITULO_PAGINA { get; set; }
        public string PALAVRAS_CHAVES { get; set; }
        public string META_DESCRIPTION { get; set; }
        public int GERAR_TAGS { get; set; }
        [StringLength(30)]
        public string PREPOSICAO_BAIRRO { get; set; }
        [StringLength(30)]
        public string PREPOSICAO_CIDADE { get; set; }
        public int CEO_CIDADE { get; set; }
        public int CEO_BAIRRO { get; set; }
        public int CEO_ZONA { get; set; }
        public int GERAR_DESCRICAO { get; set; }
        public string DESCRICAO_NO_SITE { get; set; }
        public string DESCRICAO_INTERNA { get; set; }
        public string DESCRICAO_EM_INGLES { get; set; }
        [StringLength(255)]
        public string YOUTUBE { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
