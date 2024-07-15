using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetoTransferencia
{
   public class Custos
    {
        public int ID_Custos { get; set; }
        public string Gastos { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public int Quant { get; set; }        
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public string Data { get; set; }
        public string cdc { get; set; }
        public string Favorecido { get; set; }
        
    }
}
