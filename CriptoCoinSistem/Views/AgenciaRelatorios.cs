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
using System.IO;

namespace CriptoCoinSistem
{
    public partial class AgenciaRelatorios : Form
    {
        Perfil perfil = new Perfil();

        public void setSession(Perfil perfil)
        {
            this.perfil = perfil;
        }
        public AgenciaRelatorios()
        {
            InitializeComponent();
        }

        List<Perfil> perfis;
        List<Perfil> perfisTemp;

        async private void AgenciaRelatorios_Load(object sender, EventArgs e)
        {
            perfis = await "https://criptocoin.azurewebsites.net/criptocoin/getPerfis"
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

            if (id == "Matricula" || id == "")
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

        private void filtrar()
        {
            perfisTemp = new List<Perfil>();
            dataGridView1.Rows.Clear();
            String id = inputId.Text;
            String nome = inputNome.Text;
            String cpf = inputCpf.Text;
            String cidade = inputCidade.Text;

            if (id == "Matricula" || id == "")
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

        async private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (perfisTemp == null)
            {
                perfisTemp = perfis;
            }

            List<ObjId> ids = new List<ObjId>();
            String str = "";
            foreach (Perfil p in perfisTemp)
            {
                ObjId obj = new ObjId();
                obj.Id = p.Id;
                ids.Add(obj);
            }

            var resultado = await "https://criptocoin.azurewebsites.net/criptocoin/getRelatorioPerfilPorListaId"
                .PostJsonAsync(new
                {
                    id = ids
                }).ReceiveString();
            MessageBox.Show(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            //File.WriteAllText(@Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName.ToString() + "\teste.csv",resultado);
        }
    }

    public class ObjId
    {
        public int Id { get; set; }
    }
}
