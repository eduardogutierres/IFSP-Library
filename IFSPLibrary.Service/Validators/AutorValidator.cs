using FluentValidation;
using IFSPLibrary.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Service.Validators
{
    public class AutorValidator : AbstractValidator<Autor>
    {
        public AutorValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.");

            RuleFor(a => a.Biografia)
                .NotEmpty().WithMessage("Por favor, informe a biografia.")
                .NotNull().WithMessage("Por favor, informe a biografia.");
        }
    }
}
