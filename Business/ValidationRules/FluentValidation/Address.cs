using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.UserID).NotEmpty().WithMessage("Please try to register again");
            RuleFor(x => x.CountryID).NotEmpty().NotNull().WithMessage("Please select country");
            RuleFor(x => x.CityID).NotEmpty().NotNull().WithMessage("Please select city");
            RuleFor(x => x.DistrictID).NotEmpty().NotNull().WithMessage("Please select district");
            RuleFor(x => x.Address1).NotEmpty().NotNull().WithMessage("Please enter address information");
        }
    }
}
