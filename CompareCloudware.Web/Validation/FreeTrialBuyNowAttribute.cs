using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CompareCloudware.Web.Models;

namespace CompareCloudware.Web.Validation
{
    public class ValidateFreeTrialBuyNowAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var registerViewModel = (FreeTrialBuyNowModel)validationContext.ObjectInstance;
            if (!registerViewModel.BuyNow && !registerViewModel.FreeTrial)
            {
                ErrorMessage = "Please select either BUY NOW or FREE TRIAL";
                return new ValidationResult(ErrorMessage);
            }

            return base.IsValid(value, validationContext);
        }
    }
}