using FluentValidation;
using IFSPLibrary.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Service.Validators
{
    public class EmprestimoValidator : AbstractValidator<Emprestimo>
    {
        public EmprestimoValidator()
        {
            RuleFor(e => e.Cliente)
                .NotEmpty().WithMessage("Por favor, informe o cliente.")
                .NotNull().WithMessage("Por favor, informe o cliente.");

            RuleFor(e => e.Livros)
                .NotEmpty().WithMessage("Por favor, informe os livros.")
                .NotNull().WithMessage("Por favor, informe os livros.");

            RuleFor(e => e.DataEmprestimo)
                .NotEmpty().WithMessage("Por favor, informe a data de empréstimo.")
                .NotNull().WithMessage("Por favor, informe a data de empréstimo.");

            RuleFor(e => e.DataDevolucao)
                .NotEmpty().WithMessage("Por favor, informe a data de devolução.")
                .NotNull().WithMessage("Por favor, informe a data de devolução.");
        }
    }
}
