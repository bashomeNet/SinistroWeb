using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class HomeController : Controller
    {

        [ResearchAuthorize]
        //[ChildActionOnly]//Garante que esta action não seja invocada pela url, mas somente como parcial através de Html.RenderAction(...) e Html.Action(...)
        public ActionResult Index()
        {
            ViewBag.Message = "Início";
            
            //Requisita o token de validação para requisições na base
            //var getToken = GeraToken.GeraTokenWebApi();
            //if (getToken.Exception != null)
            //{
            //    return RedirectToAction("Error", "Shared");
            //}

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }
    }
}