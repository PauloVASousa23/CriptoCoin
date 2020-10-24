using CriptoCoinApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoCoinSistem
{
    public partial class AgenciaCadastrarCliente : Form
    {
        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaCadastrarCliente()
        {
            InitializeComponent();
        }
    }
}
