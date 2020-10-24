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
    public partial class AgenciaTransacoes : Form
    {
        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaTransacoes()
        {
            InitializeComponent();
        }

        List<Carteira> carteira;
        List<Carteira> carteiraTemp;

        async private void Form5_Load(object sender, EventArgs e)
        {
            carteira = await "https://criptocoinapi.azurewebsites.net/criptocoin/getCarteiras"
            .GetJsonAsync<List<Carteira>>();

            for (int i = 0; i < carteira.Count; i++)
            {
                Perfil perfil = await ("https://criptocoinapi.azurewebsites.net/criptocoin/getPerfil/"+carteira[i].Perfil)
            .GetJsonAsync<Perfil>();
                carteira[i].PerfilCarteira = perfil;
                dataGridView1.Rows.Add(carteira[i].Criptomoeda, perfil.Nome, "R$ " + carteira[i].Valor, carteira[i].Operacao, carteira[i].Data);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carteiraTemp = new List<Carteira>();
            dataGridView1.Rows.Clear();
            String cripto = inputCripto.Text;
            String nome = inputNome.Text;
            String data = inputData.Text;

            if (cripto == "Cripto." || cripto == "")
            {
                cripto = "|_|";
            }

            if (nome == "Nome" || nome == "")
            {
                nome = "|_|";
            }

            if (data == "Data" || data == "")
            {
                data = "|_|";
            }

            foreach (Carteira carteira in carteira)
            {
                if (carteira.Criptomoeda.Contains(cripto) || cripto == "|_|")
                {
                    if (carteira.PerfilCarteira.Nome.Contains(nome) || nome == "|_|")
                    {
                        if (carteira.Data.Contains(data) || data == "|_|")
                        {
                            carteiraTemp.Add(carteira);
                        }
                    }
                }
            }

            for (int i = 0; i < carteiraTemp.Count; i++)
            {
                dataGridView1.Rows.Add(carteiraTemp[i].Criptomoeda, carteiraTemp[i].PerfilCarteira.Nome, ("R$ " + carteiraTemp[i].Valor), carteiraTemp[i].Operacao, carteiraTemp[i].Data);
            }
        }

        private void filtrar()
        {
            carteiraTemp = new List<Carteira>();
            dataGridView1.Rows.Clear();
            String cripto = inputCripto.Text;
            String nome = inputNome.Text;
            String data = inputData.Text;

            if (cripto == "Cripto." || cripto == "")
            {
                cripto = "|_|";
            }

            if (nome == "Nome" || nome == "")
            {
                nome = "|_|";
            }

            if (data == "Data" || data == "")
            {
                data = "|_|";
            }

            foreach (Carteira carteira in carteira)
            {
                if (carteira.Criptomoeda.ToLower().Contains(cripto.ToLower()) || cripto == "|_|")
                {
                    if (carteira.PerfilCarteira.Nome.ToLower().Contains(nome.ToLower()) || nome == "|_|")
                    {
                        if (carteira.Data.ToLower().Contains(data.ToLower()) || data == "|_|")
                        {
                            carteiraTemp.Add(carteira);
                        }
                    }
                }
            }

            for (int i = 0; i < carteiraTemp.Count; i++)
            {
                dataGridView1.Rows.Add(carteiraTemp[i].Criptomoeda, carteiraTemp[i].PerfilCarteira.Nome, ("R$ " + carteiraTemp[i].Valor), carteiraTemp[i].Operacao, carteiraTemp[i].Data);
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

        private void inputCripto_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void inputNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void inputData_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
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
