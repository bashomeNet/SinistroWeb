using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sinaf.WebApi.ImpPreAviso.ModelValidation
{
    public class ValidateRangeData: ValidationAttribute
    {
        public static object ValidationUtilities { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var firstComparable = value as IComparable;
            //var secondComparable = GetSecondComparable(validationContext);


            return base.IsValid(value, validationContext);  
        }


        //private static bool ValidateValue(object value, ValidationContext validationContext,
        //    List<ValidationResult> validationResults, IEnumerable<ValidationAttribute> validationAttributes,
        //    string memberPath)
        //{
        //    if (validationResults == null)
        //    {
        //        Validator.ValidateValue(value, validationContext, validationAttributes);
        //    }
        //    else
        //    {
        //        // todo, needs to be array aware
        //        List<ValidationResult> currentResults = new List<ValidationResult>();
        //        if (!Validator.TryValidateValue(value, validationContext, currentResults, validationAttributes))
        //        {
        //            // transform the validation results by applying the member path to the results
        //            if (!string.IsNullOrEmpty(memberPath))
        //            {
        //                currentResults = ValidationUtilities.ApplyMemberPath(currentResults, memberPath).ToList();
        //            }
        //            validationResults.AddRange(currentResults);
        //            return false;
        //        }
        //    }
        //    return true;
        //}


    }
}