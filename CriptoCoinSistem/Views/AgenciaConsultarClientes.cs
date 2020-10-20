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

        private void Form4_Load(object sender, EventArgs e)
        {
            /*DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "Id";
            row.Cells[1].Value = "Nome";
            row.Cells[2].Value = "CPF";
            row.Cells[3].Value = "Cidade";*/

            dataGridView1.Rows.Add("Id","Nome","CPF","Cidade");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
