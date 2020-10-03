using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Indicacoes
    {
        public int Id { get; set; }
        public string Criptomoeda { get; set; }
        public string Motivo { get; set; }
        public DateTime Data { get; set; }
        public int Perfil_Agencia { get; set; }
    }
}