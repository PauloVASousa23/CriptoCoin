
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
using Newtonsoft.Json;

namespace CriptoCoinSistem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Visible = true;
            this.Visible = false;
        }

        async private void btnEntrar_Click(object sender, EventArgs e)
        {

            String email = inputEmail.Text;
            String senha = inputSenha.Text;
            try
            {
                Perfil perfil = await "https://criptocoinapi.azurewebsites.net/criptocoin/autenticarPerfil"
                .PostJsonAsync(new { Senha = senha, Email = email }).ReceiveJson<Perfil>();
                Console.WriteLine(perfil.Id + " | " + perfil.Nome);

                if (perfil.Id == 0)
                {
                    MessageBox.Show("Usuario ou senha incorreto!");
                }
                else
                {
                    if (perfil.Permissao == 2)
                    {
                        AgenciaHome agenciaHome = new AgenciaHome();
                        agenciaHome.setSession(perfil);
                        this.Visible = false;
                        agenciaHome.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("O usuário informado não tem permissão para acesso!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

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
