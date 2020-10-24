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
    public partial class AgenciaHome : Form
    {
        Perfil perfil = new Perfil();
        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }

        public AgenciaHome()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AgenciaConsultarClientes agenciaConsultarClientes = new AgenciaConsultarClientes();
            agenciaConsultarClientes.setSession(this.perfil);
            this.Visible = false;
            agenciaConsultarClientes.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AgenciaCadastrarCliente agenciaCadastrarCliente = new AgenciaCadastrarCliente();
            agenciaCadastrarCliente.setSession(this.perfil);
            agenciaCadastrarCliente.Visible = true;
            this.Visible = false;
        }

        private void btnTransacoes_Click(object sender, EventArgs e)
        {
            AgenciaTransacoes agenciaTransacoes = new AgenciaTransacoes();
            agenciaTransacoes.setSession(this.perfil);
            agenciaTransacoes.Visible = true;
            this.Visible = false;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AgenciaRelatorios agenciaRelatorios = new AgenciaRelatorios();
            agenciaRelatorios.setSession(this.perfil);
            agenciaRelatorios.Visible = true;
            this.Visible = false;
        }

        private void btnMonitoramento_Click(object sender, EventArgs e)
        {
            AgenciaMonitoramento agenciaMonitoramento = new AgenciaMonitoramento();
            agenciaMonitoramento.setSession(this.perfil);
            agenciaMonitoramento.Visible = true;
            this.Visible = false;
        }

        private void btnIndicacoes_Click(object sender, EventArgs e)
        {
            AgenciaIndicacoes agenciaIndicacoes = new AgenciaIndicacoes();
            agenciaIndicacoes.setSession(this.perfil);
            agenciaIndicacoes.Visible = true;
            this.Visible = false;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
