using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Product name is required.")
            .NotNull().WithMessage("Product name cannot be null.")
            .MaximumLength(150).WithMessage("Product name must not exceed150 characters.");

        RuleFor(p => p.Value)
            .GreaterThanOrEqualTo(0).WithMessage("Product value cannot be negative.");

        RuleFor(p => p.Quantity)
            .GreaterThanOrEqualTo(0).WithMessage("Product quantity cannot be negative.");

        RuleFor(p => p.PurchaseDate)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Purchase date cannot be in the future.");

        RuleFor(p => p.SaleUnity)
            .NotEmpty().WithMessage("Sale unity is required.")
            .MaximumLength(20).WithMessage("Sale unity must not exceed20 characters.");

        RuleFor(p => p.Group)
            .NotNull().WithMessage("Product category is required.");
    }
}
