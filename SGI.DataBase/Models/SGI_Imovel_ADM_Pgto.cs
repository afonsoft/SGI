using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_ADM_Pgto
    {
        public long ID { get; set; }
        public long CODIGO_ADM { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public long ORIGEM { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_INCLUSAO { get; set; }
        [StringLength(150)]
        public string DESCRICAO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_VENCIMENTO { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal VALOR { get; set; }
        public string OBS { get; set; }
        public long USUARIO { get; set; }
        public bool STATUS { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DATA_PAGAMENTO { get; set; }
        public int FORMA_PGTO { get; set; }
        public string CONTA { get; set; }
        public string COMPROVANTE { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
