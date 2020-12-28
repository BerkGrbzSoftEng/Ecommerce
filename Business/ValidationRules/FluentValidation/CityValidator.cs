using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CityValidator:AbstractValidator<City>
    {
        public CityValidator()
        {
            if (CultureInfo.CurrentCulture.Name=="tr-TR")
            {
                RuleFor(x => x.CityName).NotEmpty().NotNull().WithMessage("Lütfen bir Ilçe adı giriniz");
                RuleFor(x => x.CountryID).NotEmpty().NotNull().WithMessage("Lütfen bir Il seçiniz");
                RuleFor(x => Convert.ToInt32(x.PlaqueNo)).GreaterThan(0).LessThan(81)
                    .WithMessage("Lütfen 1-81 arası bir değer giriniz");
            }
            else
            {
                RuleFor(x => x.CityName).NotEmpty().NotNull().WithMessage("Please enter City name");
                RuleFor(x => x.CountryID).NotEmpty().NotNull().WithMessage("Please select County");
                RuleFor(x => Convert.ToInt32(x.PlaqueNo)).GreaterThan(0).LessThan(81)
                    .WithMessage("Please 1 and 81 between enter Plaque Number");
            }
        }
    }
}
