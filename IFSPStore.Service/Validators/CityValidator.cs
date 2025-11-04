using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators;

public class CityValidator : AbstractValidator<City>
{
    public CityValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("City name is required.")
            .NotNull().WithMessage("City name cannot be null.")
            .MaximumLength(100).WithMessage("City name must not exceed 100 characters.");

        RuleFor(c => c.State)
            .NotEmpty().WithMessage("State is required.")
            .NotNull().WithMessage("State cannot be null.")
            .Length(2).WithMessage("State must be exactly 2 characters.")
            .Must(s => s.Equals(s.ToUpper())).WithMessage("State must be in upper case.");
    }
}
