using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Sinaf.WebApi.ImpPreAviso.Filters
{
    public class ApplyModelValidationAttribute: ActionFilterAttribute
    {
        // Responsável pela validação do DTO(elimina o uso da validação do model state no Controller)
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }
        }
    }
}