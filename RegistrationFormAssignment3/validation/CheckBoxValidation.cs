
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RegistrationFormAssignment3.validation

{
    public class CheckBoxValidation:ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-chk", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            return (bool)value;
        }
    }
}
