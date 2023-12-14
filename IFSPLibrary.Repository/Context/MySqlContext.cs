using IFSPLibrary.domain.Entities;
using IFSPLibrary.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Autor>? Autor { get; set; }
        public DbSet<Livro>? Livro { get; set; }
        public DbSet<Editora>? Editora { get; set; }
        public DbSet<Emprestimo>? Emprestimo { get; set; }
        public DbSet<EmprestimoLivro>? EmprestimoLivro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Autor>(new AutorMap().Configure);
            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<Editora>(new EditoraMap().Configure);
            modelBuilder.Entity<Emprestimo>(new EmprestimoMap().Configure);
            modelBuilder.Entity<EmprestimoLivro>(new EmprestimoLivroMap().Configure);
        }
    }
}
