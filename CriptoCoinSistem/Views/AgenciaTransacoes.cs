﻿using System;
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

        private void panel24_Click(object sender, EventArgs e)
        {
            AgenciaIndicacoes agenciaIndicacoes = new AgenciaIndicacoes();
            agenciaIndicacoes.setSession(this.perfil);
            agenciaIndicacoes.Visible = true;
            this.Visible = false;
        }
    }
}