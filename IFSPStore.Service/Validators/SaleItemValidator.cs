using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class SaleItemValidator : AbstractValidator<SaleItem>
{
    public SaleItemValidator()
    {
        RuleFor(si => si.Product)
            .NotNull().WithMessage("Product is required for sale item.");

        RuleFor(si => si.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.");

        RuleFor(si => si.UnitaryValue)
            .GreaterThanOrEqualTo(0).WithMessage("Unitary value cannot be negative.");

        RuleFor(si => si.TotalValue)
            .GreaterThanOrEqualTo(0).WithMessage("Total value cannot be negative.");

        RuleFor(si => si)
            .Must(si => si.TotalValue == si.UnitaryValue * si.Quantity)
            .WithMessage("TotalValue must be Quantity * UnitaryValue.");
    }
}
