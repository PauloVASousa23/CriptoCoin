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
    public partial class AgenciaIndicacoes : Form
    {
        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaIndicacoes()
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

        private void panel25_Click(object sender, EventArgs e)
        {

            AgenciaMonitoramento agenciaMonitoramento = new AgenciaMonitoramento();
            agenciaMonitoramento.setSession(this.perfil);
            agenciaMonitoramento.Visible = true;
            this.Visible = false;

        }

        async private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string titulo = inputTitulo.Text;
            string data = inputData.Text;
            string criptomoeda = inputCriptomoeda.Text;
            string observacao = inputObservacao.Text;

            if (
                titulo.Length < 5 ||
                data.Length < 5 ||
                criptomoeda.Length < 5 ||
                observacao.Length < 5 
            )
            {
                MessageBox.Show("Um dos campos está vazio ou muito pequeno!");
            }
            else
            {

                Indicacoes indicacao = new Indicacoes();
                indicacao.Data_Indicacao = data;
                indicacao.Criptomoeda = criptomoeda;
                indicacao.Motivo = observacao;

                var resultado = await "https://criptocoinapi.azurewebsites.net/criptocoin/setIndicacao"
                .PostJsonAsync(new
                {
                    Criptomoeda = criptomoeda,
                    Motivo = observacao,
                    Data_Indicacao = data,
                    Perfil_Agencia = perfil.Id,
                }).ReceiveString();

                if (resultado == "true")
                {
                    MessageBox.Show("Indicação cadastrada com sucesso!");
                }
                Console.WriteLine(resultado);

            }
        }
    }
}
