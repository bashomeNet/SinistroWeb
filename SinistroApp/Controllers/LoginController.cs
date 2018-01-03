using Sinaf.BLL;
using Sinaf.VOL;
using Sinaf.VOL.Sies;
using SinistroApp.Helpers;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;


namespace SinistroApp.Controllers
{
    public class LoginController : Controller
    {
        protected static log4net.ILog objLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string connectionString = ConfigurationManager.ConnectionStrings["BaseSiesHml"].ToString();

        public ActionResult Login()
        {
            ViewBag.Message = "Login";
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] //Protege a aplicação no caso de solicitações http maliciosas.
        public ActionResult Login(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioBlo ublo = new UsuarioBlo();
                    Usuario u = ublo.VerificarDadosLogin(loginModel.Login, loginModel.Senha);
                    
                    if (u != null)
                    {
                        loginModel.NmUsuario = u.nmusuari;

                        List<PR_ValidarPermissaoMenu_Result> permissoes = ublo.RetornaListaIdsPermissoes(Config.IdSistema(), loginModel.Login);
                        
                        new UserAuthorizeManager().getPermissionList(permissoes);
                        
                        SessionManager.RegisterSession(SessionKeys.NomeUsuario, loginModel.NmUsuario);
                        SessionManager.RegisterSession(SessionKeys.Usuario, loginModel);
                        SessionManager.RegisterSession(SessionKeys.Permissoes, permissoes);
                        SessionManager.RegisterSession(SessionKeys.MenuOperacoes, new UserAuthorizeManager().getPermissionList(permissoes));

                        return RedirectToAction("UserDashBoard");
                    }
                    LimparSessao();
                    ViewBag.MensagemErroLogin = "Usuário ou Senha incorretos!";
                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {
                objLog.Error("Ocorreu um erro ao processar sua solicitação!",ex);
                ViewBag.MensagemErroLogin = "Ocorreu um erro ao processar sua solicitação!";
                return View();
            }
        }
        private void LimparSessao()
        {
            SessionManager.FreeSession(SessionKeys.Usuario);
            SessionManager.FreeSession(SessionKeys.NomeUsuario);
            SessionManager.FreeSession(SessionKeys.Permissoes);
            SessionManager.FreeSession(SessionKeys.MenuOperacoes);
        }
        public ActionResult Sair()
        {
            LimparSessao();
            return RedirectToAction("Login");
        }

        public ActionResult UserDashBoard()
        {
            if (SessionManager.CheckSession(SessionKeys.Usuario))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}
