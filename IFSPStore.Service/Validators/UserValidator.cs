using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty().WithMessage("User name is required.")
            .NotNull().WithMessage("User name cannot be null.")
            .MaximumLength(100).WithMessage("User name must not exceed100 characters.");

        RuleFor(u => u.Login)
            .NotEmpty().WithMessage("Login is required.")
            .NotNull().WithMessage("Login cannot be null.")
            .MaximumLength(50).WithMessage("Login must not exceed50 characters.");

        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must be at least8 characters long.");

        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be a valid email address.");

        RuleFor(u => u.RegisterDate)
            .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Register date cannot be in the future.");

        RuleFor(u => u.LoginDate)
            .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Login date cannot be in the future.");
    }
}
