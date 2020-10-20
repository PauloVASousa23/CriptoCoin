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

        /*async private void panel6_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Funcionou o clique";
            List<Indicacoes> indicacoes = await "https://criptocoinapi.azurewebsites.net/criptocoin/getIndicacoes"
            .GetJsonAsync<List<Indicacoes>>();

        }*/

        private void panel7_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Visible = true;
            this.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AgenciaHome agenciaHome = new AgenciaHome();
            this.Visible = false;
            agenciaHome.Visible = true;
        }
    }

    
}
