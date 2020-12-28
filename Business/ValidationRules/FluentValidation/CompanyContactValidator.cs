using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CompanyContactValidator:AbstractValidator<CompanyContact>
    {
        public CompanyContactValidator()
        {
            if (CultureInfo.CurrentCulture.Name=="tr-TR")
            {
                RuleFor(x => x.Address).NotEmpty().NotNull().WithMessage("Lütfen Adres bilginizi giriniz");
                RuleFor(x => x.Address).MaximumLength(100)
                    .WithMessage("Lütfen maksimum 100 karakter olacak şekilde Adres bilginizi giriniz")
                    .MinimumLength(10).WithMessage("Lütfen minimum 10 karakter olacak şekilde adres bilginizi giriniz");
                    
            }
            else
            {
                
            }
        }
    }
}
