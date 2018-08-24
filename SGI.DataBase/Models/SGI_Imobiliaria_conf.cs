using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imobiliaria_conf
    {
        public long ID { get; set; }
        public long COD_IMOB { get; set; }
        [StringLength(200)]
        public string MAIL_HOST { get; set; }
        [StringLength(200)]
        public string MAIL_USER { get; set; }
        [StringLength(200)]
        public string MAIL_SENHA { get; set; }
        public int MAIL_PORT { get; set; }
        public int MAIL_AUT { get; set; }
        [StringLength(200)]
        public string FOTOS { get; set; }
        public int THUMB_WIDTH { get; set; }
        public int THUMB_HEIGTH { get; set; }
        public int THUMB_SLIDE_WIDTH { get; set; }
        public int THUMB_SLIDE_HEIGTH { get; set; }
        public int REF_ALTERNATIVA { get; set; }

        [ForeignKey("COD_IMOB")]
        [InverseProperty("SGI_Imobiliaria_conf")]
        public SGI_Imobiliaria COD_IMOBNavigation { get; set; }
    }
}
