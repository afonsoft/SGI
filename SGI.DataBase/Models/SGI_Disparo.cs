using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Disparo
    {
        public long ID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DATA { get; set; }
        [Column(TypeName = "time(0)")]
        public TimeSpan HORA_INICIO { get; set; }
        public int LIMITE { get; set; }
        public int DISPARO { get; set; }
        public int TOTAL_DIA { get; set; }
    }
}
