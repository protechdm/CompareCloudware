using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CompareCloudware.Web.Models;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Validation
{
    public class ValidateSurnameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> Errors = new List<string>();

            var searchInputModel = (SearchInputModel)validationContext.ObjectInstance;

            if (searchInputModel.Surname == ViewModelHelpers.SURNAME_ERROR_MESSAGE)
            {
                ErrorMessage = ViewModelHelpers.SURNAME_ERROR_MESSAGE;
                //return new ValidationResult(ErrorMessage);
                Errors.Add(ErrorMessage);
            }

            if (Errors.Count > 0)
            {
                return new ValidationResult(ErrorMessage, Errors);
            }
            else
            {
                return ValidationResult.Success;
            }
            //if (value != null)
            //{
            //    return GetValidationResult(value,validationContext);
            //}
            //else
            //{
            //    return new ValidationResult(null);
            //}
        }

        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}