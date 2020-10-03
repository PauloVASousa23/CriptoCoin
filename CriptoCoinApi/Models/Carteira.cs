using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Carteira
    {
        public int Id { get; set; }
        public int Perfil { get; set; }
        public String Criptomoeda { get; set; }
        public float Valor_Compra { get; set; }
        public float Valor_Venda { get; set; }
        public DateTime Data_Compra { get; set; }
        public DateTime Data_Venda { get; set; }
    }
}