using FluentValidation;
using IFSPLibrary.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.");

            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor, informe o endereço.")
                .NotNull().WithMessage("Por favor, informe o endereço.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor, informe o e-mail.")
                .NotNull().WithMessage("Por favor, informe o e-mail.")
                .EmailAddress().WithMessage("O e-mail informado não é válido.");
        }
    }
    
}
