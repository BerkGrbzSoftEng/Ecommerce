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
                foreach (var item in result.Result.Errors)
                {
                    throw new ValidationException("Property : "+item.PropertyName+
                                                  " failed validation. \nError was : " +item.ErrorMessage+
                                                  "\nError Code : "+item.ErrorCode);
                }
            }


        }
    }
}
