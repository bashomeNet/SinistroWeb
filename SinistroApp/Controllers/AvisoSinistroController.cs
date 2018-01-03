using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class AvisoSinistroController : Controller
    {
        //Grid Coberturas / Aviso Sinistro
        private static GridCoberturasContext _coberuras = new GridCoberturasContext();
        //Grid Histórico / Aviso Sinistro
        private static GridHistoricoContext _historicos = new GridHistoricoContext();
        //Grid Indenização / Aviso Sinistro
        private static GridIndenizacaoContext _indenizacoes = new GridIndenizacaoContext();
        //Grid Despesas / Aviso Sinistro
        private static GridDespesasContext _despesas = new GridDespesasContext();

        public ActionResult AvisoSinistro()
        {
            ViewBag.Message = "Aviso Sinistro";

            var getToken = GeraToken.GeraTokenWebApi();
            if (getToken.Exception != null)
            {
                return RedirectToAction("Error", "Shared");
            }

            var listCoberturas = _coberuras.listaCoberturas;
            ViewData.Add("GrdCoberturas", listCoberturas);

            var listHistoricos = _historicos.listaHistoricos;
            ViewData.Add("GrdHistoricos", listHistoricos);

            var grdIndenizacoes = _indenizacoes.listaIndenizacoes;
            ViewData.Add("GrdIndenizacoes", grdIndenizacoes);

            var grdDespesas = _despesas.listaDespesas;
            ViewData.Add("GrdDespesas", grdDespesas);

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }

        [HttpGet]
        public JsonResult ListaIndenizacoes()
        {

            try
            {

                List<GridIndenizacaoModel> indenizacoes = new List<GridIndenizacaoModel>();
                var listIndenizacoes = _indenizacoes.listaIndenizacoes;

                foreach (var item in listIndenizacoes)
                {
                    GridIndenizacaoModel indenizacao = new GridIndenizacaoModel();
                    indenizacao.idInd = item.idInd;
                    indenizacao.bancoInd = item.bancoInd;
                    indenizacao.agenciaInd = item.agenciaInd;
                    indenizacao.contaInd = item.contaInd;
                    indenizacao.dtVencimentoInd = item.dtVencimentoInd;
                    indenizacao.codIndenizacaoInd = item.codIndenizacaoInd;
                    indenizacao.situacaoInd = item.situacaoInd;
                    indenizacao.coberturaInd = item.coberturaInd;
                    indenizacao.beneficiarioInd = item.beneficiarioInd;
                    indenizacao.valTotalInd = item.valTotalInd;

                    indenizacoes.Add(indenizacao);
                }

                if (indenizacoes != null)
                {
                    //Response.StatusCode = 1;
                    return Json(new { indenizacoes }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao buscar os dados de indenizações." }, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception)
            {
                return Json(new { message = "Erro ao buscar os dados de indenizações." }, JsonRequestBehavior.AllowGet);
                throw;
            }
        }

        [HttpGet]
        public JsonResult ListaDespesas()
        {

            try
            {

                List<GridDespesasModel> despesas = new List<GridDespesasModel>();
                var listDespesas = _despesas.listaDespesas;

                foreach (var item in listDespesas)
                {
                    GridDespesasModel despesa = new GridDespesasModel();
                    despesa.idDesp = item.idDesp;
                    despesa.bancoDesp = item.bancoDesp;
                    despesa.agenciaDesp = item.agenciaDesp;
                    despesa.contaDesp = item.contaDesp;
                    despesa.dtVencimentoDesp = item.dtVencimentoDesp;
                    despesa.codIndenizacaoDesp = item.codIndenizacaoDesp;
                    despesa.situacaoDesp = item.situacaoDesp;
                    despesa.coberturaDesp = item.coberturaDesp;
                    despesa.beneficiarioDesp = item.beneficiarioDesp;
                    despesa.valTotalDesp = item.valTotalDesp;

                    despesas.Add(despesa);
                }

                if (despesas != null)
                {
                    //Response.StatusCode = 1;
                    return Json(new { despesas }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao buscar os dados de despesas." }, JsonRequestBehavior.AllowGet);
                }

            }
            catch (Exception)
            {
                return Json(new { message = "Erro ao buscar os dados de despesas." }, JsonRequestBehavior.AllowGet);
                throw;
            }
        }
    }
}
