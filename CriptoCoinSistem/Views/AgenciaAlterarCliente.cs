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

        async private void btnCadastrar_Click(object sender, EventArgs e)
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
    }
}
