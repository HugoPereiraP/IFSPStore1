using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Customer name is required.")
            .NotNull().WithMessage("Customer name cannot be null.")
            .MaximumLength(100).WithMessage("Customer name must not exceed100 characters.");

        RuleFor(c => c.Address)
            .NotEmpty().WithMessage("Address is required.")
            .NotNull().WithMessage("Address cannot be null.")
            .MaximumLength(200).WithMessage("Address must not exceed200 characters.");

        RuleFor(c => c.Document)
            .NotEmpty().WithMessage("Document is required.")
            .NotNull().WithMessage("Document cannot be null.")
            .MaximumLength(20).WithMessage("Document must not exceed20 characters.");

        RuleFor(c => c.Neighborhood)
            .NotEmpty().WithMessage("Neighborhood is required.")
            .NotNull().WithMessage("Neighborhood cannot be null.")
            .MaximumLength(100).WithMessage("Neighborhood must not exceed100 characters.");

        RuleFor(c => c.City)
            .NotNull().WithMessage("City is required.");
    }
}
