using FluentValidation;
using IFSPLibrary.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Service.Validators
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(l => l.Titulo)
                .NotEmpty().WithMessage("Por favor, informe o título.")
                .NotNull().WithMessage("Por favor, informe o título.");

            RuleFor(l => l.Autor)
                .NotEmpty().WithMessage("Por favor, informe o autor.")
                .NotNull().WithMessage("Por favor, informe o autor.");

            RuleFor(l => l.AnoPublicacao)
                .NotEmpty().WithMessage("Por favor, informe o ano de publicação.")
                .NotNull().WithMessage("Por favor, informe o ano de publicação.")
                .GreaterThan(0).WithMessage("O ano de publicação deve ser maior que zero.");

            RuleFor(l => l.Editora)
                .NotEmpty().WithMessage("Por favor, informe a editora.")
                .NotNull().WithMessage("Por favor, informe a editora.");
        }
    }
}
