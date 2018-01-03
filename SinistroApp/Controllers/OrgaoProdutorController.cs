using Newtonsoft.Json;
using Sinaf.BLL;
using Sinaf.VOL.Sies;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class OrgaoProdutorController : Controller
    {

        // GET: Usuarios
        //public async Task<ActionResult> RecuperarTodos()
        //{
        //    var client = WebApiHttpClient.GetClient();
        //    HttpResponseMessage response = await client.GetAsync("busca/todos");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        string content = await response.Content.ReadAsStringAsync();
        //        var empresas =
        //        JsonConvert.DeserializeObject<IEnumerable<OrgaoProdutorModel>>(content);

        //        return Json(new { empresas }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        Response.StatusCode = 503;
        //        return Json(new { message = "Erro ao buscar a lista de empresas." }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        [ResearchAuthorize]
        [HttpGet]
        public JsonResult RecuperarEmpresa()
        {
            try
            {
                List<OrgaoProdutor> listaEmpresas = new OrgaoProdutorBlo().RetornarEmpresas();
                return Json(new { listaEmpresas }, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception)
            {
                Response.StatusCode = 503;
                return Json(new { message = "Erro ao buscar a lista de empresas." }, JsonRequestBehavior.AllowGet);
            }
        }

        [ResearchAuthorize]
        [HttpGet]
        public JsonResult RecuperarSucursalId(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { message = "Empresa não informada, erro ao buscar a lista de sucursais." }, JsonRequestBehavior.AllowGet);
            }
     

            try
            {
                List<OrgaoProdutor> listaSucursais = new OrgaoProdutorBlo().RetornarSucursaisPorIdEmpresa(id);
                return Json(new { listaSucursais }, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception)
            {
                Response.StatusCode = 503;
                return Json(new { message = "Erro ao buscar a lista de sucursais." }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
