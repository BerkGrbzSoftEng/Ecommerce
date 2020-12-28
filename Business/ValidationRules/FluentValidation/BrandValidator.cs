using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            if (CultureInfo.CurrentCulture.Name=="tr-TR")
            {

                ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");
 
                RuleFor(x => x.BrandName).NotNull().NotEmpty().WithMessage("Lütfen isim alanını doldurunuz");
                RuleFor(x => x.BrandName).Length(2, 50).WithMessage("Lütfen Marka Adınızı En Az 2 En Fazla 50 olcak şekilde giriniz.");
                RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen Başlık kısmını en fazla 50 karakter olcak şekilde giriniz.");
                RuleFor(x => x.MetaTitle).MaximumLength(100).WithMessage("Lütfen Meta Tagini En Fazla 100 karakter olcak şekilde giriniz.");

            }
            else
            {
                RuleFor(x => x.BrandName).NotNull().NotEmpty().WithMessage("Please enter brand name");
                RuleFor(x => x.BrandName).Length(2, 50).WithMessage("Please enter brand name Min:2 - Max:50 character ");
                RuleFor(x => x.Title).MaximumLength(50).WithMessage("Please enter 50 characters max.");
                RuleFor(x => x.MetaTitle).MaximumLength(100).WithMessage("Please enter 100 characters max.");
            }
          
            
        }
    }
}
