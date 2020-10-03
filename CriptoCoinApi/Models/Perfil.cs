using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Perfil
    {
        int Id;
        public String Nome { get; set; }
        public String Email;
        public String Rg{ get; set; }
        public String Cpf{ get; set; }
        int Cep{ get; set; }
        public String Cidade{ get; set; }
        public String Bairro{ get; set; }
        public String Endereco{ get; set; }
        int Conta{ get; set; }
        public String Agencia{ get; set; }
        public String Permissao{ get; set; }

        
    }
}