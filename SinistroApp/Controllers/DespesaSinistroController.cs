using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class DespesaSinistroController : Controller
    {
        public ActionResult DespesaSinistro()
        {
            ViewBag.Message = "Despesa Sinistro";

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }
    }
}
