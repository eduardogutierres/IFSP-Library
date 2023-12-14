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
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.AnoPublicacao);
                

            builder.HasOne(prop => prop.Autor);

            builder.HasOne(prop => prop.Editora);
        }
    }

}
