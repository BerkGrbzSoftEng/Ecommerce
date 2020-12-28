using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            if (CultureInfo.CurrentCulture.Name == "tr-TR")
            {
                RuleFor(x => x.CategoryName).NotNull().NotEmpty().WithMessage("Lütfen Kategori adını giriniz");
                RuleFor(x => x.CategoryName).Length(2, 100)
                    .WithMessage("Lütfen Kategori adı alanı en az 2 en fazla 100 karakter olacak şekilde giriniz");
                RuleFor(x => x.Description).MaximumLength(100)
                    .WithMessage("Lütfen Acıklama alanına en fazla 100 karakter giriniz");
                RuleFor(x => x.SubTitle).MaximumLength(100)
                    .WithMessage("Lütfen Alt Başlık alanına en fazla 100 karakter giriniz");
                RuleFor(x => x.MetaTitle).MaximumLength(100)
                    .WithMessage("Lütfen Meta Tagi alanına en fazla 100 karakter giriniz");
                RuleFor(x => x.UrlRoute).MaximumLength(100)
                    .WithMessage("Lütfen Url alanına en fazla 100 karakter giriniz");
            }
            else
            {
                RuleFor(x => x.CategoryName).NotEmpty().NotNull().WithMessage("Please enter Category name");
                RuleFor(x => x.CategoryName).Length(2, 100)
                    .WithMessage("Please enter Min. 2 and Max. 100 character Category name");
                RuleFor(x => x.Description).MaximumLength(100)
                    .WithMessage("Please enter  and Max. 100 character SubTitle");
                RuleFor(x => x.Description).MaximumLength(100) 
                    .WithMessage("Please enter  Max. 100 character MetaTitle");
                RuleFor(x => x.Description).MaximumLength(100)
                    .WithMessage("Please enter  Max. 100 character UrlRoute");
            }

        }
    }
}
