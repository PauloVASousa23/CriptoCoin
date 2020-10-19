using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Permissao
    {
        public int Id { get; set; }
        public String PermissaoUsuario { get; set; }
        public String Descricao { get; set; }
    }
}