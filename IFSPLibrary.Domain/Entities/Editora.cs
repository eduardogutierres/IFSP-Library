using IFSPLibrary.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Entities
{
    public class Editora : BaseEntity<int>
    {
        public Editora()
        {

        }

        public Editora(int id, string? nome, string? localizacao) : base(id)
        {
            Nome = nome;
            Localizacao = localizacao;
        }

        public string? Nome { get; set; }
        public string? Localizacao { get; set; }
        
    }

}
