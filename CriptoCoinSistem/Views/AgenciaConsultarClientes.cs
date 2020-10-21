using CriptoCoinApi.Models;
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

        private async void Form4_LoadAsync(object sender, EventArgs e)
        {
            /*DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "Id";
            row.Cells[1].Value = "Nome";
            row.Cells[2].Value = "CPF";
            row.Cells[3].Value = "Cidade";*/
            
            List<Perfil> perfis = await "https://criptocoinapi.azurewebsites.net/criptocoin/getPerfis"
            .GetJsonAsync<List<Perfil>>();

            for (int i=0;i < perfis.Count;i++)
            {

                dataGridView1.Rows.Add(perfis[i].Id, perfis[i].Nome, perfis[i].Cpf, perfis[i].Cidade);
            }
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");
            dataGridView1.Rows.Add("001", "Teste", "000.000.000-00", "São Paulo");

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
                //...
            }
            //DataGridViewRow row = dataGridView1.SelectedRows;

            //Console.WriteLine(row.Cells[1].Value.ToString());
        }
    }
}
