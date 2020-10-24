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
    public partial class AgenciaTransacoes : Form
    {
        public AgenciaTransacoes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                dataGridView1.Rows.Add(carteira[i].Criptomoeda, perfil.Nome, carteira[i].Valor, carteira[i].Operacao, carteira[i].Data);
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
                dataGridView1.Rows.Add(carteiraTemp[i].Criptomoeda, carteiraTemp[i].PerfilCarteira.Nome, carteiraTemp[i].Valor, carteiraTemp[i].Operacao, carteiraTemp[i].Data);
            }
        }
    }
}
