using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using CriptoCoinApi.Models;
using CriptoCoinApi.Repositorio;

namespace CriptoCoinApi.Controllers
{
    public class CriptocoinController : Controller
    {

        [HttpGet]
        public JsonResult GetPermissao(int id=0)
        {

            PermissaoRepositorio permissaoRepos = new PermissaoRepositorio();
            Permissao permissao = permissaoRepos.selecionarPermissao(id);
            return Json(permissao, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetPermissoes()
        {

            PermissaoRepositorio permissaoRepos = new PermissaoRepositorio();
            List<Permissao> permissoes = permissaoRepos.selecionarPermissoes();
            return Json(permissoes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SetPermissao([System.Web.Http.FromBody]Permissao permissao)
        {

            PermissaoRepositorio permissaoRepos = new PermissaoRepositorio();
            bool result = permissaoRepos.inserirPermissao(permissao);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult DeletePermissao(int id = 0)
        {

            PermissaoRepositorio permissaoRepos = new PermissaoRepositorio();
            bool resultado = permissaoRepos.deletarPermissao(id);
            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetConta(int id = 0)
        {

            ContaRepositorio contaRepos = new ContaRepositorio();
            Conta conta = contaRepos.selecionarConta(id);
            return Json(conta, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetContas()
        {

            ContaRepositorio contaRepos = new ContaRepositorio();
            List<Conta> contas = contaRepos.selecionarContas();
            return Json(contas, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult SetContas(Conta conta)
        {

            ContaRepositorio contaRepos = new ContaRepositorio();
            bool result = contaRepos.inserirConta(conta);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult DeleteContas(int id = 0)
        {

            ContaRepositorio contaRepos = new ContaRepositorio();
            bool result = contaRepos.deletarConta(id);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetPerfil(int id = 0)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            Perfil perfil = perfilRepos.selecionarPerfil(id);
            return Json(perfil, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult AutenticarPerfil(string email = "", string senha = "")
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            Perfil perfil = perfilRepos.autenticarPerfil(email,senha);
            return Json(perfil, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetPerfis()
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis();
            return Json(perfis, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetPerfisAgencia(int id)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis(id);
            return Json(perfis, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult SetPerfil(Perfil perfil)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            bool result = perfilRepos.inserirPerfil(perfil);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult UpdatePerfil(Perfil perfil)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            bool result = perfilRepos.atualizarPerfil(perfil);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult DeletePerfil(int id = 0)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            bool result = perfilRepos.deletarPerfil(id);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetCarteira(int id = 0)
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            List<Carteira> carteiras = carteiraRepos.selecionarCarteira(id);
            return Json(carteiras, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetCarteiras()
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            List<Carteira> carteira = carteiraRepos.selecionarCarteiras();
            return Json(carteira, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetValorCarteira(int id)
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            List<Carteira> carteira = carteiraRepos.selecionarCarteira(id);
            Carteira bitcoin = new Carteira();
            bitcoin.Valor = 0;
            bitcoin.Criptomoeda = "Bitcoin";
            Carteira ethereum = new Carteira();
            ethereum.Valor = 0;
            ethereum.Criptomoeda = "Ethereum";
            Carteira litecoin = new Carteira();
            litecoin.Valor = 0;
            litecoin.Criptomoeda = "Litecoin";
            foreach (Carteira c in carteira)
            {
                switch (c.Criptomoeda)
                {
                    case "Bitcoin":
                        if (c.Operacao == "Compra")
                        {
                            bitcoin.Valor = bitcoin.Valor + c.Valor;
                        }
                        else if(c.Operacao == "Venda")
                        {
                            bitcoin.Valor = bitcoin.Valor - c.Valor;
                        }
                        break;
                    case "Litecoin":
                        if (c.Operacao == "Compra")
                        {
                            litecoin.Valor = litecoin.Valor + c.Valor;
                        }
                        else if (c.Operacao == "Venda")
                        {
                            litecoin.Valor = litecoin.Valor - c.Valor;
                        }
                        break;
                    case "Ethereum":
                        if (c.Operacao == "Compra")
                        {
                            ethereum.Valor = ethereum.Valor + c.Valor;
                        }
                        else if (c.Operacao == "Venda")
                        {
                            ethereum.Valor = ethereum.Valor - c.Valor;
                        }
                        break;
                    default:
                        break;
                }
            }

            List<Carteira> saldo = new List<Carteira>();
            saldo.Add(bitcoin);
            saldo.Add(ethereum);
            saldo.Add(litecoin);

            return Json(saldo, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult SetCarteira(Carteira carteira)
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            bool result = carteiraRepos.inserirCarteira(carteira);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult DeleteCarteira(int id = 0)
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            bool result = carteiraRepos.deletarCarteira(id);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetIndicacao(int id = 0)
        {

            IndicacoesRepositorio indicacaoRepos = new IndicacoesRepositorio();
            List<Indicacoes> indicacao = indicacaoRepos.selecionarIndicacao(id);
            return Json(indicacao, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetIndicacoes()
        {

            IndicacoesRepositorio indicacaoRepos = new IndicacoesRepositorio();
            List<Indicacoes> indicacoes = indicacaoRepos.selecionarIndicacoes();
            return Json(indicacoes, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult SetIndicacao(Indicacoes indicacoes)
        {

            IndicacoesRepositorio indicacaoRepos = new IndicacoesRepositorio();
            bool result = indicacaoRepos.inserirIndicacoes(indicacoes);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult DeleteIndicacao(int id = 0)
        {

            IndicacoesRepositorio indicacaoRepos = new IndicacoesRepositorio();
            bool result = indicacaoRepos.deletarIndicacao(id);
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public FileContentResult GetRelatorioPerfil() {
            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis();


            string csv = "Matricula;Nome;Email;Rg;Cpf;Cep;Cidade;Bairro;Endereço;Agencia;\n";

            foreach (Perfil perfil in perfis)
            {
                csv += perfil.Id + ";" + perfil.Nome.ToString() + " " + string.Empty + string.Empty + ";" + perfil.Email.ToString() + " " + string.Empty + ";" + perfil.Rg.ToString() + " " + string.Empty + ";" + perfil.Cpf.ToString() + " " + string.Empty + ";" + perfil.Cep.ToString() + " " + string.Empty + ";" + perfil.Cidade.ToString() + " " + string.Empty + ";" + perfil.Bairro.ToString() + " " + string.Empty + ";" + perfil.Endereco.ToString() + " " + string.Empty + ";" + perfil.Agencia.ToString() + " " + string.Empty + ";\n";
            }

            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "RelatorioPerfis.csv");
        }

        [HttpGet]
        public FileContentResult GetRelatorioPerfilPorId(int id)
        {
            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis(id);

            string csv = "Matricula;Nome;Email;Rg;Cpf;Cep;Cidade;Bairro;Endereço;Agencia;\n";

            foreach (Perfil perfil in perfis)
            {
                csv += perfil.Id + ";" + perfil.Nome.ToString() +" "+ ";" + perfil.Email.ToString() + " " + string.Empty + ";" + perfil.Rg.ToString() + " " + string.Empty + ";" + perfil.Cpf.ToString() + " " + string.Empty + ";" + perfil.Cep.ToString() + " " + string.Empty + ";" + perfil.Cidade.ToString() + " " + string.Empty + ";" + perfil.Bairro.ToString() + " " + string.Empty + ";" + perfil.Endereco.ToString() + " " + string.Empty + ";" + perfil.Agencia.ToString() + " " + string.Empty + ";\n";
            }

            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "RelatorioPerfis.csv");
        }

        [HttpPost]
        public FileContentResult GetRelatorioPerfilPorListaId(IdObj[] id)
        {
            String IdIn = "";
            for (int i = 0; i < id.Length; i++)
            {
                if (i != id.Length - 1)
                {
                    IdIn += id[i].Id + ", ";
                }
                else
                {
                    IdIn += id[i].Id;
                }
            }
            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis(IdIn);

            string csv = "Matricula;Nome;Email;Rg;Cpf;Cep;Cidade;Bairro;Endereço;Agencia;\n";

            foreach (Perfil perfil in perfis)
            {
                csv += perfil.Id + ";" + perfil.Nome.ToString() + " " + ";" + perfil.Email.ToString() + " " + string.Empty + ";" + perfil.Rg.ToString() + " " + string.Empty + ";" + perfil.Cpf.ToString() + " " + string.Empty + ";" + perfil.Cep.ToString() + " " + string.Empty + ";" + perfil.Cidade.ToString() + " " + string.Empty + ";" + perfil.Bairro.ToString() + " " + string.Empty + ";" + perfil.Endereco.ToString() + " " + string.Empty + ";" + perfil.Agencia.ToString() + " " + string.Empty + ";\n";
            }

            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "RelatorioPerfis.csv");
        }
    }

    public class IdObj
    {
        public int Id { get; set; }
    }
}