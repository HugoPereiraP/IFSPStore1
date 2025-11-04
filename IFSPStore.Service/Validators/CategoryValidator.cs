using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .NotNull().WithMessage("Category name cannot be null.")
            .MaximumLength(100).WithMessage("Category name must not exceed100 characters.");

        RuleFor(c => c.Description)
            .MaximumLength(500).WithMessage("Category description must not exceed500 characters.");
    }
}
