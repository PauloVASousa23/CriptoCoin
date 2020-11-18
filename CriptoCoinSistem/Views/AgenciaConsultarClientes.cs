using CriptoCoinApi.Models;
using CriptoCoinSistem.Views;
using Flurl.Http;
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
    public partial class AgenciaConsultarClientes : Form
    {
        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaConsultarClientes()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        public List<Perfil> perfis;
        public List<Perfil> perfisTemp;

        private async void Form4_LoadAsync(object sender, EventArgs e)
        {
            
            perfis = await "https://criptocoin.azurewebsites.net/criptocoin/getPerfis"
            .GetJsonAsync<List<Perfil>>();

            for (int i=0;i < perfis.Count;i++)
            {
                dataGridView1.Rows.Add(perfis[i].Id, perfis[i].Nome, perfis[i].Cpf, perfis[i].Cidade);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                Console.WriteLine(value2);
                bool achouId = true;
                for (int i = 0;i<perfis.Count;i++)
                {
                    achouId = perfis[i].Id == Int32.Parse(value1);

                    if (achouId)
                    {
                        lblNome.Text = perfis[i].Nome;
                        lblRg.Text = perfis[i].Rg;
                        lblCpf.Text = perfis[i].Cpf;
                        lblCidade.Text = perfis[i].Cidade;
                        lblSaldo.Text = "R$ 000,00";
                        lblId.Text = perfis[i].Id+"";
                        lblSaldo.Text = "R$ " + perfis[i].Saldo;
                        achouId = false;
                    }
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                bool achouId = true;
                for (int i = 0; i < perfis.Count; i++)
                {
                    achouId = perfis[i].Id == Int32.Parse(value1);

                    if (achouId)
                    {
                        AgenciaAlterarCliente agenciaAlterarCliente = new AgenciaAlterarCliente();
                        agenciaAlterarCliente.inicializaPerfil(perfis[i]);
                        agenciaAlterarCliente.Visible = true;
                        this.Visible = false;
                    }
                }


            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            perfisTemp = new List<Perfil>();
            dataGridView1.Rows.Clear();
            String id = inputId.Text;
            String nome = inputNome.Text;
            String cpf = inputCpf.Text;

            if (id == "ID" || id == "")
            {
                id = "0";
            }

            if (nome == "Nome" || nome == "")
            {
                nome = "|_|";
            }

            if (cpf == "CPF" || cpf == "")
            {
                cpf = "|_|";
            }

            foreach (Perfil perfil in perfis)
            {
                if( perfil.Id == Int32.Parse(id) || id == "0")
                {
                    if ( perfil.Nome.Contains(nome) || nome == "|_|" )
                    {
                        if ( perfil.Cpf.Contains(cpf) || cpf == "|_|" )
                        {
                            perfisTemp.Add(perfil);
                        }
                    }
                }
            }

            for (int i = 0; i < perfisTemp.Count; i++)
            {
                dataGridView1.Rows.Add(perfisTemp[i].Id, perfisTemp[i].Nome, perfisTemp[i].Cpf, perfisTemp[i].Cidade);
            }

        }

        private void filtrar()
        {
            perfisTemp = new List<Perfil>();
            dataGridView1.Rows.Clear();
            String id = inputId.Text;
            String nome = inputNome.Text;
            String cpf = inputCpf.Text;

            if (id == "ID" || id == "")
            {
                id = "0";
            }

            if (nome == "Nome" || nome == "")
            {
                nome = "|_|";
            }

            if (cpf == "CPF" || cpf == "")
            {
                cpf = "|_|";
            }

            foreach (Perfil perfil in perfis)
            {
                if (perfil.Id == Int32.Parse(id) || id == "0")
                {
                    if (perfil.Nome.ToLower().Contains(nome.ToLower()) || nome == "|_|")
                    {
                        if (perfil.Cpf.ToLower().Contains(cpf.ToLower()) || cpf == "|_|")
                        {
                            perfisTemp.Add(perfil);
                        }
                    }
                }
            }

            for (int i = 0; i < perfisTemp.Count; i++)
            {
                dataGridView1.Rows.Add(perfisTemp[i].Id, perfisTemp[i].Nome, perfisTemp[i].Cpf, perfisTemp[i].Cidade);
            }
        }

        private void inputId_Click(object sender, EventArgs e)
        {
            String id = inputId.Text;

            if (id == "ID")
            {
                inputId.Text = "";
            }

        }

        private void inputNome_Click(object sender, EventArgs e)
        {
            String nome = inputNome.Text;

            if (nome == "Nome")
            {
                inputNome.Text = "";
            }
        }

        private void inputCpf_Click(object sender, EventArgs e)
        {
            String cpf = inputCpf.Text;

            if (cpf == "CPF" )
            {
                inputCpf.Text = "";
            }
        }

        private void inputId_Leave(object sender, EventArgs e)
        {
            String id = inputId.Text;

            if (id == "")
            {
                inputId.Text = "ID";
            }
        }

        private void inputNome_Leave(object sender, EventArgs e)
        {
            String nome = inputNome.Text;

            if (nome == "")
            {
                inputNome.Text = "Nome";
            }
        }

        private void inputCpf_Leave(object sender, EventArgs e)
        {
            String cpf = inputCpf.Text;

            if (cpf == "")
            {
                inputCpf.Text = "CPF";
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void inputId_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void inputNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void inputCpf_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }
    }
}
