using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarDetailDtoValidator:AbstractValidator<CarDetailDto>
    {
        public CarDetailDtoValidator()
        {
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c => c.ColourName).NotEmpty();
        }
    }
}
