using IFSPLibrary.domain.Base;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IFSPLibrary.domain.Entities
{
    public class Emprestimo : BaseEntity<int>
    {
        public Emprestimo()
        {
            Livros = new List<EmprestimoLivro>();
        }

        public Emprestimo(int id, DateTime data_emprestimo, DateTime data_devolucao, Cliente? cliente, List<EmprestimoLivro> livros) : base(id)
        {
            DataEmprestimo = data_emprestimo;
            DataDevolucao = data_devolucao;
            Cliente = cliente;
            Livros = livros;
        }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<EmprestimoLivro> Livros { get; set; }
        
    }

    public class EmprestimoLivro : BaseEntity<int>
    {
        public EmprestimoLivro()
        {
        }

        public EmprestimoLivro(int id, Livro livro, int quantidade) : base(id)
        {
            Livro = livro;
            Quantidade = quantidade;
        }

        public int Quantidade { get; set; }

        [JsonIgnore]
        public virtual Emprestimo? Emprestimo { get; set; }

        public virtual Livro? Livro { get; set; }
    }
}
