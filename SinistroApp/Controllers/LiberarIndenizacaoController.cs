using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class LiberarIndenizacaoController : Controller
    {
        //Grid Liberar Indenização / Liberar Indenização
        private static GridLibIndenizContext _libIndenizacoes = new GridLibIndenizContext();

        public ActionResult LiberarIndenizacao()
        {
            ViewBag.Message = "Liberar Indenização";

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View(_libIndenizacoes.listLibIndenizacoes);
        }
    }
}
