using Newtonsoft.Json;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class PessoaController : Controller
    {
        private string username = System.Configuration.ConfigurationManager.AppSettings["UserToken"];
        private string password = System.Configuration.ConfigurationManager.AppSettings["PasswordToken"];

        public ActionResult Pessoa()
        {
            ViewBag.Message = "Pessoa";

            // Chamada do token público
            var getToken = GeraToken.GeraTokenWebApi();
            if (getToken.Exception != null)
            {
                return RedirectToAction("Error", "Shared");
            }

            //var listPermitida = GeraPermissoes.ConfiguraPermissaoMenu();

            ////Chama a partial view menu passando o objeto que carrega a lista de itens do menu
            //ViewData.Add("ItensMenu", listPermitida);

            return View();
        }

        //
        // POST: /Pessoa/GeraTokenWebApi
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
                System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                HttpResponseMessage response = client.PostAsync("/Token", content).Result;

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

        // GET: Pessoas - Método onde a lista é retornada no back end da aplicação através da chamada cliente/Web Api
        public async Task<ActionResult> RecuperarTodos()
        {
            try
            {
                var client = WebApiHttpClient.GetClient();
                HttpResponseMessage response = await client.GetAsync("api/Pessoa");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var pessoas =
                    JsonConvert.DeserializeObject<IEnumerable<PessoaModel>>(content);

                    return Json(new { pessoas }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao buscar a lista de pessoas." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
