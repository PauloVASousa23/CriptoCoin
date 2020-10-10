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

        [HttpGet]
        public JsonResult GetPerfis()
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            List<Perfil> perfis = perfilRepos.selecionarPerfis();
            return Json(perfis, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult SetPerfil(Perfil perfil)
        {

            PerfilRepositorio perfilRepos = new PerfilRepositorio();
            bool result = perfilRepos.inserirPerfil(perfil);
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
            Carteira carteira = carteiraRepos.selecionarCarteira(id);
            return Json(carteira, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult GetCarteiras()
        {

            CarteiraRepositorio carteiraRepos = new CarteiraRepositorio();
            List<Carteira> carteira = carteiraRepos.selecionarCarteiras();
            return Json(carteira, JsonRequestBehavior.AllowGet);

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
            Indicacoes indicacao = indicacaoRepos.selecionarIndicacao(id);
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
    }
}