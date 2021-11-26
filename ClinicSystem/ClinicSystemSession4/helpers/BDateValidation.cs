using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicSystemSession4.helpers
{
    public class BDateValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                if( Convert.ToDateTime(value) >= DateTime.Now)
                {
                    return new ValidationResult("Birth date should not grater than current date");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Birth date is required");
            }
        }
    }
}
