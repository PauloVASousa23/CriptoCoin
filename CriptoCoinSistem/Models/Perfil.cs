using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public String Endereco { get; set; }
        public int Agencia { get; set; }
        public int Permissao { get; set; }
        public float Saldo { get; set; }
    }
}