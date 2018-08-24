using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Ficha_Imovel
    {
        public long ID { get; set; }
        public long COD_FICHA { get; set; }
        public long COD_ATENDIMENTO { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        [StringLength(30)]
        public string IMOVEL { get; set; }
        public long COD_IMOVEL { get; set; }

        public SGI_CRM_Ficha_Visita COD_ { get; set; }
    }
}
