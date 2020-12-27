using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Core.CrossCuting.Validation
{
    public class ValidatorTool
    {
        public static void FluentValidation(IValidator validator,object entity)
        {
            var result = validator.ValidateAsync((IValidationContext)entity);
            if (result.Result.Errors.Count>0)
            {
                throw new ValidationException(result.Result.Errors);
            }


        }
    }
}
