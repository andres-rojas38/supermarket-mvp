using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void Validate(object model) 
        {
            string errorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(
                model, validationContext, validationResults, true);
            if (isValid == false)
            {
                foreach (var item in validationResults)
                {
                    errorMessage += item.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }

        }
    }
}
