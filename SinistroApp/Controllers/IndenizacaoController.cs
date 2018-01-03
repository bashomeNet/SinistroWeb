using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class IndenizacaoController : Controller
    {
        //Combos Operações
        private static CmbOperacaoContext _operacoes = new CmbOperacaoContext();

        public ActionResult Indenizacao()
        {
            ViewBag.Message = "Indenização";

            var listOperacoes = _operacoes.listaOperacoes;
            ViewData.Add("CmbOperacoes", listOperacoes);

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }
    }
}
