using Sinaf.VOL.Sies;
using SinistroApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SinistroApp.Helpers
{
    public struct SessionKeys
    {
        public const string Usuario = "Usuario";
        public const string NomeUsuario = "NomeUsuario";
        public const string Permissoes = "Permissoes";
        public const string MenuOperacoes = "MenuPrincipal";

    }

    public class ResearchAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //if (httpContext.SkipAuthorization) return true; // hack to avoid multiple call to the method
            if (SessionManager.CheckSession(SessionKeys.Usuario) == true) {

                var rd = httpContext.Request.RequestContext.RouteData;
                string currentAction = rd.GetRequiredString("action");
                string currentController = rd.GetRequiredString("controller");
                string currentArea = rd.Values["area"] as string;

                //httpContext.SkipAuthorization = true;

                return new UserAuthorizeManager().CheckUserPermission(currentController + "/"+ currentAction);
            }
            else
                return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            if (SessionManager.CheckSession(SessionKeys.Usuario) == false)
            {
                filterContext.Result = new RedirectToRouteResult(
                                new RouteValueDictionary
                        {
                        { "action", "Login" },
                        { "controller", "Login" }
                        });
            }
            else
            {               
                base.HandleUnauthorizedRequest(filterContext);
            }
                
        }
    }
}