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
            string senha = inputSenha.Text;
            string reSenha = inputReSenha.Text;

            if (
                nome.Length < 5 ||
                rg.Length < 5 ||
                cpf.Length < 5 ||
                telefone.Length < 5 ||
                email.Length < 5 ||
                cep.Length < 5 ||
                cidade.Length < 5 ||
                bairro.Length < 5 ||
                logradouro.Length < 5 ||
                senha.Length < 5 ||
                reSenha.Length < 5
            )
            {
                MessageBox.Show("Um dos campos está vazio ou muito pequeno!");
            }
            else
            {
                if (senha == reSenha)
                {
                    Perfil perfil = new Perfil();
                    perfil.Nome = nome;
                    perfil.Rg = rg;
                    perfil.Cpf = cpf;
                    perfil.Email = email;
                    perfil.Cep = cep;
                    perfil.Cidade = cidade;
                    perfil.Bairro = bairro;
                    perfil.Endereco = logradouro;
                    perfil.Senha = senha;
                    perfil.Permissao = 1;
                    perfil.Agencia = 1;

                    var resultado = await "https://criptocoinapi.azurewebsites.net/criptocoin/setPerfil"
                .PostJsonAsync(new
                {
                    Nome = nome,
                    Rg = rg,
                    Cpf = cpf,
                    Email = email,
                    Cep = cep,
                    Cidade = cidade,
                    Bairro = bairro,
                    Endereco = logradouro,
                    Senha = senha,
                    Permissao = 1,
                    Agencia = perfil.Id
                }).ReceiveString();

                    if (resultado == "true")
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                    }
                    Console.WriteLine(resultado);
                }
                else
                {
                    MessageBox.Show("As senhas digitadas não são iguais!");
                }
            }

        }
    }
}
