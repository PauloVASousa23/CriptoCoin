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
        public AgenciaConsultarClientes()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        public List<Perfil> perfis;

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
    }
}
