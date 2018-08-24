using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Venda
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_VENDA { get; set; }
        public long USUARIO { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
