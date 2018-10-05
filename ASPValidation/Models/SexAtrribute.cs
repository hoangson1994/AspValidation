using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPValidation.Models
{
    public class SexAtrribute : ValidationAttribute
    {
        private string[] _temp = new string[] { "sex", "porn" };
        public SexAtrribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Product product = (Product)validationContext.ObjectInstance;

            if (product.Name.Contains(_temp[0]) || product.Name.Contains(_temp[1]))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return $"Name not sex or porn";
        }
    }
}
