using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryHiearchyValidator:AbstractValidator<CategoryHiearchy>
    {
        public CategoryHiearchyValidator()
        {
            if (CultureInfo.CurrentCulture.Name=="tr-TR")
            {
                RuleFor(x => x.MainCatID).NotEmpty().NotNull().WithMessage("Lütfen bir Ana Kategori seçiniz");
                RuleFor(x=>x.CatID).NotNull().NotEmpty().WithMessage("Lütfen bir Kategori seçiniz");

            }
            else
            {
                RuleFor(x => x.MainCatID).NotEmpty().NotNull().WithMessage("Please select Main Category");
                RuleFor(x => x.CatID).NotNull().NotEmpty().WithMessage("Please select Category");

            }
        }
    }
}
