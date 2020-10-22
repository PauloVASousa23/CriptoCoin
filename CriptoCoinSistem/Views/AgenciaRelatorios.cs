using CriptoCoinApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace CriptoCoinSistem
{
    public partial class AgenciaRelatorios : Form
    {
        public AgenciaRelatorios()
        {
            InitializeComponent();
        }

        List<Perfil> perfis;
        List<Perfil> perfisTemp;

        async private void AgenciaRelatorios_Load(object sender, EventArgs e)
        {
            perfis = await "https://criptocoinapi.azurewebsites.net/criptocoin/getPerfis"
            .GetJsonAsync<List<Perfil>>();

            for (int i = 0; i < perfis.Count; i++)
            {
                dataGridView1.Rows.Add(perfis[i].Id, perfis[i].Nome, perfis[i].Cpf, perfis[i].Cidade);
            }
        }

        private void filtrarDataView()
        {
            perfisTemp = new List<Perfil>();
            dataGridView1.Rows.Clear();
            String id = inputId.Text;
            String nome = inputNome.Text;
            String cpf = inputCpf.Text;
            String cidade = inputCidade.Text;

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

            if (cidade == "Cidade" || cidade == "")
            {
                cidade = "|_|";
            }

            foreach (Perfil perfil in perfis)
            {
                if (perfil.Id == Int32.Parse(id) || id == "0")
                {
                    if (perfil.Nome.Contains(nome) || nome == "|_|")
                    {
                        if (perfil.Cpf.Contains(cpf) || cpf == "|_|")
                        {
                            if (perfil.Cidade.Contains(cidade) || cidade == "|_|")
                            {
                                perfisTemp.Add(perfil);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < perfisTemp.Count; i++)
            {
                dataGridView1.Rows.Add(perfisTemp[i].Id, perfisTemp[i].Nome, perfisTemp[i].Cpf, perfisTemp[i].Cidade);
            }
        }

        private void inputId_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDataView();
        }

        private void inputNome_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDataView();
        }

        private void inputCpf_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDataView();
        }

        private void inputCidade_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDataView();
        }

        private void inputId_Click(object sender, EventArgs e)
        {
            if (inputId.Text == "ID")
            {
                inputId.Text = "";
            }
        }

        private void inputNome_Click(object sender, EventArgs e)
        {
            if (inputNome.Text == "Nome")
            {
                inputNome.Text = "";
            }
        }

        private void inputCpf_Click(object sender, EventArgs e)
        {
            if (inputCpf.Text == "CPF")
            {
                inputCpf.Text = "";
            }
        }

        private void inputCidade_Click(object sender, EventArgs e)
        {
            if (inputCidade.Text == "Cidade")
            {
                inputCidade.Text = "";
            }
        }
    }
}
