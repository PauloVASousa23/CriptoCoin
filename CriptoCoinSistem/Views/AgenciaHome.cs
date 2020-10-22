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
    public partial class AgenciaHome : Form
    {
        public AgenciaHome()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            AgenciaConsultarClientes agenciaConsultarClientes = new AgenciaConsultarClientes();
            this.Visible = false;
            agenciaConsultarClientes.Visible = true;
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            AgenciaTransacoes agenciaTransacoes = new AgenciaTransacoes();
            agenciaTransacoes.Visible = true;
            this.Visible = false;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            AgenciaCadastrarCliente agenciaCadastrarCliente = new AgenciaCadastrarCliente();
            agenciaCadastrarCliente.Visible = true;
            this.Visible = false;
        }
    }
}
