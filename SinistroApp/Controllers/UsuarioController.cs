using Newtonsoft.Json;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SinistroApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuarios
        public async Task<ActionResult> BuscarTodos()
        {
            var client = WebApiHttpClient.GetClient();
            HttpResponseMessage response = await client.GetAsync("todos/usuarios");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var usuarios =
                JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(content);
                //return View(usuarios);

                List<UsuarioModel> listUsuarios = new List<UsuarioModel>();

                foreach (var item in usuarios)
                {
                    UsuarioModel usuario = new UsuarioModel();

                    usuario.IdUsuario = item.IdUsuario;
                    usuario.NmUsuario = item.NmUsuario;
                    usuario.DtNascimento = item.DtNascimento;
                    usuario.Email = item.Email;

                    listUsuarios.Add(usuario);
                }

                return Json(new { listUsuarios }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = 503;
                return Json(new { message = "Erro ao buscar os dados de usuários." }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Consulta/usuario/id
        public async Task<ActionResult> BuscarUsuarioId(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = WebApiHttpClient.GetClient();
            HttpResponseMessage response = await client.GetAsync("consulta/usuario/" + id);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var usuario = JsonConvert.DeserializeObject<UsuarioModel>(content);
                if (usuario == null) return HttpNotFound();

                return Json(new { usuario }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = 503;
                return Json(new { message = "Erro ao buscar os dados do usuário." }, JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Insere/usuario
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> InserirUsuario(
        [Bind(Include = "NmUsuario, DtNascimento, Email")] UsuarioModel usuario)
        {
            try
            {
                var client = WebApiHttpClient.GetClient();
                string usuarioJSON = JsonConvert.SerializeObject(usuario);
                HttpContent content = new StringContent(usuarioJSON,
                System.Text.Encoding.Unicode, "application/json");
                var response = await client.PostAsync("insere/usuario", content);
                if (response.IsSuccessStatusCode)
                {
                    return Json(new { }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao inserir o usuário." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(new { message = "Erro ao inserir o usuário." }, JsonRequestBehavior.AllowGet);
            }

        }

        // GET: Atualiza/usuario/id
        [HttpPut]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> AtualizarUsuario(
        [Bind(Include = "IdUsuario, NmUsuario, DtNascimento, Email")] UsuarioModel usuario)
        {
            try
            {
                var client = WebApiHttpClient.GetClient();
                string usuarioJSON = JsonConvert.SerializeObject(usuario);
                HttpContent content = new StringContent(usuarioJSON,
                System.Text.Encoding.Unicode, "application/json");
                var response =
                await client.PutAsync("atualiza/usuario/" + usuario.IdUsuario, content);
                if (response.IsSuccessStatusCode)
                {
                    return Json(new { }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao atualizar o usuário." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(new { message = "Erro ao atualizar o usuário." }, JsonRequestBehavior.AllowGet);
            }

        }

        // DELETE: Deleta/usuario/id
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeletarUsuario(int id)
        {
            try
            {
                var client = WebApiHttpClient.GetClient();
                var response = await client.DeleteAsync("deleta/usuario/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return Json(new { }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    Response.StatusCode = 503;
                    return Json(new { message = "Erro ao deletar o usuário." }, JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(new { message = "Erro ao deletar o usuário." }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
