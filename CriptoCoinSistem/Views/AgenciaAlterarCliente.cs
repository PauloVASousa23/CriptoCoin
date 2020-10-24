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
using Flurl.Http;

namespace CriptoCoinSistem.Views
{
    public partial class AgenciaAlterarCliente : Form
    {
        public Perfil perfil;
        public void inicializaPerfil(Perfil perfil)
        {
            this.perfil = perfil;
            inputNome.Text = perfil.Nome;
            inputRg.Text = perfil.Rg;
            inputCpf.Text = perfil.Cpf;
            inputTelefone.Text = "(00) 00000-0000";
            inputEmail.Text = perfil.Email;
            inputCep.Text = perfil.Cep;
            inputEstado.Text = perfil.Bairro;
            inputCidade.Text = perfil.Cidade;
            inputLogradouro.Text = perfil.Endereco;
        }

        public AgenciaAlterarCliente()
        {
            InitializeComponent();
        }

        async private void AgenciaAlterarCliente_Click(object sender, EventArgs e)
        {
            Perfil perfilNovo = new Perfil();
            perfilNovo.Id = perfil.Id;
            perfilNovo.Nome = inputNome.Text;
            perfilNovo.Rg = inputRg.Text;
            perfilNovo.Cpf = inputCpf.Text;
            //inputTelefone.Text = "(00) 00000-0000";
            perfilNovo.Email = inputEmail.Text;
            perfilNovo.Cep = inputCep.Text;
            perfilNovo.Bairro = inputEstado.Text;
            perfilNovo.Cidade = inputCidade.Text;
            perfilNovo.Endereco = inputLogradouro.Text;
            perfilNovo.Agencia = perfil.Agencia;
            perfilNovo.Permissao = perfil.Permissao;
            perfilNovo.Senha = perfil.Senha;

            var resultado = await "https://criptocoinapi.azurewebsites.net/criptocoin/updatePerfil"
                .PostJsonAsync(new
                {
                    Id = perfilNovo.Id,
                    Nome = perfilNovo.Nome,
                    Rg = perfilNovo.Rg,
                    Cpf = perfilNovo.Cpf,
                    Email = perfilNovo.Email,
                    Cep = perfilNovo.Cep,
                    Cidade = perfilNovo.Cidade,
                    Bairro = perfilNovo.Bairro,
                    Endereco = perfilNovo.Endereco,
                    Senha = perfilNovo.Senha,
                    Permissao = perfilNovo.Permissao,
                    Agencia = perfilNovo.Senha
                }).ReceiveString();

            if (resultado == "true")
            {
                MessageBox.Show("Dados alterados com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar dados do cliente, tente novamente!");
            }
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

        private void btnTelaCadastrar_Click(object sender, EventArgs e)
        {
            AgenciaCadastrarCliente agenciaCadastrarCliente = new AgenciaCadastrarCliente();
            agenciaCadastrarCliente.setSession(this.perfil);
            agenciaCadastrarCliente.Visible = true;
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
