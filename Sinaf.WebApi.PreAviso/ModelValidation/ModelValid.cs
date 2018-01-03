using Newtonsoft.Json;
using Sinaf.BLL;
using Sinaf.WebApi.PreAviso.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Sinaf.WebApi.ImpPreAviso.ModelValidation
{
    public sealed class ModelValid
    {
        public ICollection<ValidationResult> ValidationResults { get; set; }
        private object _model { get; set; }
        private bool _throwIfIsNotValid { get; set; }

        public bool IsValid { get; private set; }
        public ModelValid(object model)
        {
            _model = model;
        }
        public void DoValidation()
        {
            ValidationResults = new List<ValidationResult>();
            IsValid = Validator.TryValidateObject(_model, new ValidationContext(_model), ValidationResults, true)
                & ValidarData(_model);

            if ((!IsValid) && _throwIfIsNotValid) ThrowException();
        }

        public ModelValid(object model, bool throwIfIsNotValid)
            : this(model)
        {
            _throwIfIsNotValid = throwIfIsNotValid;
        }

        public void ThrowException()
        {
            throw new ValidationException(ErrorMessages());
        }
        public string ErrorMessages()
        {
            string message = string.Empty;

            var obj = "";
            if (!IsValid)
            {
                if (ValidationResults != null && ValidationResults.Count > 0)
                {
                    IEnumerator<ValidationResult> results = ValidationResults.GetEnumerator();

                    while (results.MoveNext())
                    {
                        ValidationResult vr = results.Current;
                        if(vr != null)
                            message += vr.ErrorMessage + System.Environment.NewLine;
                    }
                    
                }

                obj = JsonConvert.SerializeObject(message, new JsonSerializerSettings());
            }

            return obj;
        }

        private bool ValidarData(object model)
        {
            ValidationResult valor = null;
            PreAvisoDTO obj = new PreAvisoDTO();
            obj = (PreAvisoDTO)model;
            string[] strObjeto;


            if (obj.Data_evento > DateTime.Now)
            {
                strObjeto = new string[1];
                strObjeto[0] = "Data_evento";
                valor = new ValidationResult(string.Format("A Data do Evento: {0} precisa ser menor que a data atual!", obj.Data_evento), strObjeto);
                ValidationResults.Add(valor);
            }


            if ((obj.Data_comunicacao_sinistro > DateTime.Now) && (obj.Data_comunicacao_sinistro > obj.Data_evento))
            {
                strObjeto = new string[1];
                strObjeto[0] = "Data_comunicacao_sinistro";
                valor = new ValidationResult(string.Format("A data de comunicação do sinistro é maior que a data atual e menor que a data do evento."),strObjeto);
                ValidationResults.Add(valor);
            }


            if (obj.Lista_de_Causa_Mortis.Length > 0)
            {
                CausaSinistroBlo objCausaSinistro = new CausaSinistroBlo();
                foreach (Object item in obj.Lista_de_Causa_Mortis)
                {
                    if (objCausaSinistro.RecuperarCausaSinistro(Convert.ToInt32(item)) == null)
                    {
                        strObjeto = new string[1];
                        strObjeto[0] = "Lista_de_Causa_Mortis";
                        valor = new ValidationResult(string.Format("A causa Mortis:{0} não existe na Base de dados", item),strObjeto);
                        ValidationResults.Add(valor);
                    }
                }
            }

            if (ValidationResults.Count <= 0)
                return true;
            else
                return false;

        }

    }
}