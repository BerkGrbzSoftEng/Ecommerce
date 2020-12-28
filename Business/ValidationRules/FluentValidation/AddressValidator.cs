using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            if (CultureInfo.CurrentCulture.Name=="tr-TR")
            {
                RuleFor(x => x.UserID).NotEmpty().NotNull().WithMessage("Lütfen kayıt olmak için tekrar deneyiniz.");
                RuleFor(x => x.CountryID).NotEmpty().NotNull().WithMessage("Lütfen bir Ulke seçiniz");
                RuleFor(x => x.CityID).NotEmpty().NotNull().WithMessage("Lütfen bir Il seçiniz");
                RuleFor(x => x.DistrictID).NotEmpty().NotNull().WithMessage("Lütfen bir Ilçe seçiniz");
                RuleFor(x => x.Address1).NotEmpty().NotNull().WithMessage("Lütfen Adres bilgisini giriniz.");
                RuleFor(x => x.PostCode).Must(x => x.ToString().Length == 5).WithMessage("Lütfen 5 haneli Posta kodunuzu giriniz");
                RuleFor(x => x.Address1).Length(10, 120).WithMessage("Lütfen Adres bilginizi En Az 10 En Fazla 120 karakter olacak şekilde giriniz");
                RuleFor(x => x.Address2).Length(10, 120).WithMessage("Lütfen Adres bilginizi En Az 10 En Fazla 120 karakter olacak şekilde giriniz");

            }
            else
            {
                RuleFor(x => x.UserID).NotEmpty().NotNull().WithMessage("Please try to register again");
                RuleFor(x => x.CountryID).NotEmpty().NotNull().WithMessage("Please select country");
                RuleFor(x => x.CityID).NotEmpty().NotNull().WithMessage("Please select city");
                RuleFor(x => x.DistrictID).NotEmpty().NotNull().WithMessage("Please select district");
                RuleFor(x => x.Address1).NotEmpty().NotNull().WithMessage("Please enter address information");
                RuleFor(x => x.PostCode).Must(x => x.ToString().Length == 5).WithMessage("Please enter your 5 digit postcode");
                RuleFor(x => x.Address1).Length(10, 120).WithMessage("Please enter Min. 10 and Max. 120 character address information");
                RuleFor(x => x.Address2).Length(10, 120).WithMessage("Please enter Min. 10 and Max. 120 character address information");


            }

        }
    }
}
