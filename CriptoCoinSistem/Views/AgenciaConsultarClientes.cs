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
            
            perfis = await "https://criptocoinapi.azurewebsites.net/criptocoin/getPerfis"
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

                    Console.WriteLine(perfis[i].Id + " - " + value1);
                    if (achouId)
                    {
                        lblNome.Text = perfis[i].Nome;
                        lblRg.Text = perfis[i].Rg;
                        lblCpf.Text = perfis[i].Cpf;
                        lblCidade.Text = perfis[i].Cidade;
                        lblSaldo.Text = "R$ 000,00";
                        lblId.Text = perfis[i].Id+"";
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
    }
}
