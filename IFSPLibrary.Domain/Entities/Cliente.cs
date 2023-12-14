using IFSPLibrary.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {

        }

        public Cliente(int id, string? nome, string? email, string? endereco) : base(id)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
    }
}
