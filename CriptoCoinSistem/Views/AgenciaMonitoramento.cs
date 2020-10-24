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
    public partial class AgenciaMonitoramento : Form
    {
        public AgenciaMonitoramento()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void BTC(object sender, PaintEventArgs e)
        {

        }

        private void BTC(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaMonitoramento()
        {
            InitializeComponent();
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            AgenciaConsultarClientes agenciaConsultarClientes = new AgenciaConsultarClientes();
            agenciaConsultarClientes.setSession(this.perfil);
            agenciaConsultarClientes.Visible = true;
            this.Visible = false;
        }

        private void panel21_Click(object sender, EventArgs e)
        {

            AgenciaCadastrarCliente agenciaCadastrarCliente = new AgenciaCadastrarCliente();
            agenciaCadastrarCliente.setSession(this.perfil);
            agenciaCadastrarCliente.Visible = true;
            this.Visible = false;

        }

        private void panel22_Click(object sender, EventArgs e)
        {

            AgenciaTransacoes agenciaTransacoes = new AgenciaTransacoes();
            agenciaTransacoes.setSession(this.perfil);
            agenciaTransacoes.Visible = true;
            this.Visible = false;

        }

        private void panel23_Click(object sender, EventArgs e)
        {

            AgenciaRelatorios agenciaRelatorios = new AgenciaRelatorios();
            agenciaRelatorios.setSession(this.perfil);
            agenciaRelatorios.Visible = true;
            this.Visible = false;

        }

        private void panel24_Click(object sender, EventArgs e)
        {

            AgenciaIndicacoes agenciaIndicacoes = new AgenciaIndicacoes();
            agenciaIndicacoes.setSession(this.perfil);
            agenciaIndicacoes.Visible = true;
            this.Visible = false;
        }

        async private void AgenciaMonitoramento_Load(object sender, EventArgs e)
        {
            Ticker tickerBtc = await "https://www.mercadobitcoin.net/api/BTC/ticker/"
            .GetJsonAsync<Ticker>();

            Ticker tickerEth = await "https://www.mercadobitcoin.net/api/ETH/ticker/"
            .GetJsonAsync<Ticker>();

            Ticker tickerLtc = await "https://www.mercadobitcoin.net/api/LTC/ticker/"
            .GetJsonAsync<Ticker>();

            lblVolumeBtc.Text = tickerBtc.ticker.vol.ToString();
            lblValorBtc.Text = tickerBtc.ticker.sell.ToString();

            lblVolumeEth.Text = tickerEth.ticker.vol.ToString();
            lblValorEth.Text = tickerEth.ticker.sell.ToString();

            lblVolumeLtc.Text = tickerLtc.ticker.vol.ToString();
            lblValorLtc.Text = tickerLtc.ticker.sell.ToString();
        }
    }

    public class Ticker
    {
        public Criptomoedas ticker { get; set; }
    }

    public class Criptomoedas
    {
        public float high { get; set; }
        public float low { get; set; }
        public float vol { get; set; }
        public float last { get; set; }
        public float buy { get; set; }
        public float sell { get; set; }
        public int date { get; set; }
    }
}
}
