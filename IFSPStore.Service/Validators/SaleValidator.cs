using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(s => s.Date)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Sale date cannot be in the future.");

        RuleFor(s => s.TotalValue)
            .GreaterThanOrEqualTo(0).WithMessage("Total value cannot be negative.");

        RuleFor(s => s.Salesman)
            .NotNull().WithMessage("Salesman is required.");

        RuleFor(s => s.Customer)
            .NotNull().WithMessage("Customer is required.");

        RuleFor(s => s.Items)
            .NotNull().WithMessage("Sale items list cannot be null.")
            .Must(items => items != null && items.Count >0).WithMessage("Sale must have at least one item.");
    }
}
