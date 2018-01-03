using Newtonsoft.Json;
using Sinaf.WebApi.PreAviso.DTOs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sinaf.WebApi.ImpPreAviso.ModelValidation;
using Sinaf.WebApi.ImpPreAviso.Filters;
using Sinaf.BLL;
using Sinaf.VOL.Sinistro;
using Sinaf.WebApi.PreAviso.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Sinaf.WebApi.PreAviso.Controllers
{
    public class PreAvisoController : ApiController
    {
        // GET: api/PreAviso
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PreAviso/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PreAviso
        [HttpPost]
        [ApplyModelValidation]
        public IHttpActionResult Post([FromBody]object value)
        {
            ICollection<ValidationResult> ValidationResults = null;
            ModelValid modelValid = null;
            PreAvisoBlo preAvisoBlo = new PreAvisoBlo();


            try
            {
                bool blnRetono = true;
                PreAvisoDTO obj = new PreAvisoDTO();

                if (value != null)
                    obj = JsonConvert.DeserializeObject<PreAvisoDTO>(value.ToString());
                else
                    Request.CreateResponse(HttpStatusCode.NotFound);


               Sinaf.VOL.DTOs.PreAviso _preAviso = AutoMapperManager.Instance.Mapper.Map<PreAvisoDTO, Sinaf.VOL.DTOs.PreAviso>(obj);
               blnRetono = preAvisoBlo.IncluirRecebimento(_preAviso, value.ToString());

                if (blnRetono)
                {
                    modelValid = new ModelValid(obj, true);
                    modelValid.DoValidation();
                    if (modelValid.IsValid)
                    {
                        preAvisoBlo.GravarImportacaoAceita();
                        
                    }

                }

               return Created($"{Request.RequestUri}/", obj);
                   
            }
            catch( Exception ex)
            {
                ValidationResults = modelValid.ValidationResults;
                preAvisoBlo.ValidaDadosObrigatorios(ValidationResults);

                ArgumentException obj = new ArgumentException(ex.Message);

                return InternalServerError(obj);
            }
        }

        // PUT: api/PreAviso/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PreAviso/5
        public void Delete(int id)
        {
        }



    }
}
