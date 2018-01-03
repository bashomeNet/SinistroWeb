using SinistroApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class DetalhePessoaController : Controller
    {
        public ActionResult DetalhePessoa()
        {
            ViewBag.Message = "Detalhe Pessoa";

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }
    }
}