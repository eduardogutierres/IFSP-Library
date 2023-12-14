using IFSPLibrary.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Entities
{
    public class Livro : BaseEntity<int>
    {
        public Livro()
        {

        }

        public Livro(int id, string? titulo, Autor? autor, int ano_publicacao, Editora? editora) : base(id)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = ano_publicacao;
            Editora = editora;
        }

        public string? Titulo { get; set; }
        public Autor? Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public Editora? Editora { get; set; }
    }

}
