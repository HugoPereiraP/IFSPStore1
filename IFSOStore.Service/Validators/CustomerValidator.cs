using FluentValidation;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;


namespace IFSOStore.Service.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do Cliente obrigatorio!");
            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("Documento do Cliente obrigatorio!");
                
        }  
    }
}
