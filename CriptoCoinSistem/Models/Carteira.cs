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
        public float Valor { get; set; }
        public String Data { get; set; }
        public String Operacao { get; set; }
        public Perfil PerfilCarteira { get; set; }
    }
}