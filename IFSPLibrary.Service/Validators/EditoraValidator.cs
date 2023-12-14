using FluentValidation;
using IFSPLibrary.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Service.Validators
{
    public class EditoraValidator : AbstractValidator<Editora>
    {
        public EditoraValidator()
        {
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome.")
                .NotNull().WithMessage("Por favor, informe o nome.");

            RuleFor(e => e.Localizacao)
                .NotEmpty().WithMessage("Por favor, informe a localização.")
                .NotNull().WithMessage("Por favor, informe a localização.");
        }
    }
}
