using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGI.DataBase.Models
{
    public partial class SGI_Imovel_Temporada
    {
        public long ID { get; set; }
        public long COD_IMOVEL { get; set; }
        public long COD_ORIGEM { get; set; }
        public long COD_UNIDADE { get; set; }
        public int QTD_DIAS_BAIXA { get; set; }
        public double VALOR_DIARIA_BAIXA { get; set; }
        public int QTD_DIAS_NATAL { get; set; }
        public double VALOR_DIARIA_NATAL { get; set; }
        public int QTD_DIAS_REV { get; set; }
        public double VALOR_DIARIA_REV { get; set; }
        public int QTD_DIAS_DATAS { get; set; }
        public double VALOR_DIARIA_DATAS { get; set; }
        public int QTD_DIAS_NATAL_REV { get; set; }
        public double VALOR_DIARIA_NATAL_REV { get; set; }
        public int QTD_DIAS_TEMP { get; set; }
        public double VALOR_DIARIA_TEMP { get; set; }
        public int QTD_DIAS_CARNAVAL { get; set; }
        public double VALOR_DIARIA_CARNAVAL { get; set; }
        public double VALOR_CAUCAO { get; set; }
        public double VALOR_LIMPEZA { get; set; }
        public double VALOR_ADM { get; set; }

        public SGI_Imovel COD_ { get; set; }
    }
}
