using IFSPLibrary.domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Repository.Mapping
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.DataEmprestimo)
                .IsRequired();

            builder.Property(prop => prop.DataDevolucao)
                .IsRequired();

            builder.HasOne(prop => prop.Cliente);

            builder.HasMany(prop => prop.Livros)
                .WithOne(prop => prop.Emprestimo);
        }
    }

    public class EmprestimoLivroMap : IEntityTypeConfiguration<EmprestimoLivro>
    {
        public void Configure(EntityTypeBuilder<EmprestimoLivro> builder)
        {
            builder.ToTable("EmprestimoLivro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Quantidade)
                .IsRequired();

            builder.HasOne(prop => prop.Emprestimo);

            builder.HasOne(prop => prop.Livro);
        }
    }
}
