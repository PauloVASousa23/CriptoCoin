using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CriptoCoinApi.Models;
using Flurl.Http;

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

        async private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = inputNome.Text;
            string rg = inputRg.Text;
            string cpf = inputCpf.Text;
            string telefone = inputTelefone.Text;
            string email = inputEmail.Text;
            string cep = inputCep.Text;
            string cidade = inputCidade.Text;
            string bairro = inputBairro.Text;
            string logradouro = inputLogradouro.Text;
            string senha = cpf.Replace(".", string.Empty).Replace("-",string.Empty).Substring(0,6);

            if (
                nome.Length < 5 ||
                rg.Length < 5 ||
                cpf.Length < 5 ||
                telefone.Length < 5 ||
                email.Length < 5 ||
                cep.Length < 5 ||
                cidade.Length < 5 ||
                bairro.Length < 5 ||
                logradouro.Length < 5
            )
            {
                MessageBox.Show("Um dos campos está vazio ou muito pequeno!");
            }
            else
            {
                
                var resultado = await "https://criptocoin.azurewebsites.net/criptocoin/setPerfil"
                .PostJsonAsync(new
                {
                    Nome = nome,
                    Rg = rg,
                    Cpf = cpf,
                    Email = email,
                    Telefone = telefone,
                    Cep = cep,
                    Cidade = cidade,
                    Bairro = bairro,
                    Endereco = logradouro,
                    Senha = senha,
                    Permissao = 1,
                    Agencia = this.perfil.Id,
                    Saldo = 0
                }).ReceiveString();

                if (resultado == "true")
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                Console.WriteLine(resultado);
                
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AgenciaConsultarClientes agenciaConsultarClientes = new AgenciaConsultarClientes();
            agenciaConsultarClientes.setSession(this.perfil);
            this.Visible = false;
            agenciaConsultarClientes.Visible = true;
        }

        private void btnTelaCadastrar_Click(object sender, EventArgs e)
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
