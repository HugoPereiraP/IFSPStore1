using FluentValidation;
using IFSPStore.Domain.Entities;


namespace IFSOStore.Service.Validators
{
    public class UserValidator : AbstractValidator<User>    
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("O nome do usuário não pode ser vazio.")
                .MaximumLength(100).WithMessage("O nome do usuário não pode exceder 100 caracteres.");
        }
    }
}
