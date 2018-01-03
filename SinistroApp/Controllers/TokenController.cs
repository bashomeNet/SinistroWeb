using Newtonsoft.Json;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class TokenController : Controller
    {

        private string username = System.Configuration.ConfigurationManager.AppSettings["UserToken"];
        private string password = System.Configuration.ConfigurationManager.AppSettings["PasswordToken"];
        HttpResponseMessage response;

        public ActionResult UsuarioTeste()
        {
            ViewBag.Message = "Teste Usuário";

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }

        //
        // POST: /Token/GeraTokenWebApi
        [HttpPost] //Tipo da requisição.
        [AllowAnonymous] //Permite que usuários anônimos acessem o método. Para solicitação do controller via json.
        //[ValidateAntiForgeryToken] //Protege a aplicação no caso de solicitações http maliciosas.
        public async Task<ActionResult> GeraTokenWebApi()
        {
            try
            {
                var client = WebApiHttpClient.GetClient();
                HttpContent content = new StringContent(
                "username=" + username + "&password=" + password + "&grant_type=password",
                System.Text.Encoding.UTF8,"application/x-www-form-urlencoded");
                response = client.PostAsync("/Token", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TokenResponse tokenResponse = await response.Content.ReadAsAsync<TokenResponse>();
                    WebApiHttpClient.storeToken(tokenResponse);
                    //return RedirectToAction("UsuarioTeste", "Token");
                    return Json(new { tokenResponse.AccessToken }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Content("Ocorreu um erro: " + response.StatusCode);
                }

            }
            catch
            {
                return Content("Ocorreu um erro na geração do token.");
            }
        }

    }
}
