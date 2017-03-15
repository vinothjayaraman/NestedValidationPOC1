using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NestedValidationPOC_1.Validation
{
    public class SalesItemValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = true;
            var validationErrorMessage = "";
            if (value == null)
            {
                validationResult = false;
                validationErrorMessage = "Value can't be null";
            }
            else if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                validationResult = false;
                validationErrorMessage = "Value can't be empty";
            }
            

            return validationResult ? ValidationResult.Success : new ValidationResult(validationErrorMessage);
        }
    }
}