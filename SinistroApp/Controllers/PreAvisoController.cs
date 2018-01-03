using Sinaf.BLL;
using Sinaf.VOL.Sies;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class PreAvisoController : Controller
    {
        //Grid Pré Avisos / Pré Aviso
        private static GridPreAvisoContext _preAvisos = new GridPreAvisoContext();

        [ResearchAuthorize]
        public ActionResult PreAviso()
        {
            ViewBag.Message = "Pré Aviso";

            //var getToken = GeraToken.GeraTokenWebApi();
            //if (getToken.Exception != null)
            //{
            //    return RedirectToAction("Error", "Shared");
            //}
            


            return View(_preAvisos.listaPreAvisos);
        }

        [ResearchAuthorize]
        [HttpGet]
        public JsonResult ListaPreAvisos()
        {

            try
            {

                List<GridPreAvisoModel> preAvisos = new List<GridPreAvisoModel>();

                return Json(new { preAvisos }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {
                return Json(new { message = "Erro ao buscar os dados de pré avisos." }, JsonRequestBehavior.AllowGet);
                throw;
            }
        }

        [ResearchAuthorize]
        [HttpGet]
        public JsonResult RecuperarSituacoesPreAviso()
        {
            
            try
            {
                List<DominioCampo> listaSituacoes = new DominioCampoBlo().RetornarSituacoesPreAviso();
                return Json(new { listaSituacoes }, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception)
            {
                Response.StatusCode = 503;
                return Json(new { message = "Erro ao buscar a lista de situações." }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
