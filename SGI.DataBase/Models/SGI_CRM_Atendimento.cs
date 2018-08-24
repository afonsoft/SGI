using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_CRM_Atendimento
    {
        public SGI_CRM_Atendimento()
        {
            SGI_CRM_Agenda = new HashSet<SGI_CRM_Agenda>();
            SGI_CRM_Atendimento_Historico = new HashSet<SGI_CRM_Atendimento_Historico>();
            SGI_CRM_Cliente_Imovel = new HashSet<SGI_CRM_Cliente_Imovel>();
            SGI_CRM_Ficha_Visita = new HashSet<SGI_CRM_Ficha_Visita>();
            SGI_CRM_Processo = new HashSet<SGI_CRM_Processo>();
        }

        [Key]
        public long COD_ATENDIMENTO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_INICIO { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA_FINAL { get; set; }
        public long COD_CLIENTE { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public long ATENDENTE { get; set; }
        public bool STATUS { get; set; }
        public bool ENCERRAMENTO { get; set; }

        public SGI_CRM_Cliente COD_ { get; set; }
        public ICollection<SGI_CRM_Agenda> SGI_CRM_Agenda { get; set; }
        public ICollection<SGI_CRM_Atendimento_Historico> SGI_CRM_Atendimento_Historico { get; set; }
        public ICollection<SGI_CRM_Cliente_Imovel> SGI_CRM_Cliente_Imovel { get; set; }
        public ICollection<SGI_CRM_Ficha_Visita> SGI_CRM_Ficha_Visita { get; set; }
        public ICollection<SGI_CRM_Processo> SGI_CRM_Processo { get; set; }
    }
}
