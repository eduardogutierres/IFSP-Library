using IFSPLibrary.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Entities
{
    public class Autor : BaseEntity<int>
    {
        public Autor()
        {

        }

        public Autor(int id, string? nome, string? biografia) : base(id)
        {
            Nome = nome;
            Biografia = biografia;
        }

        public string? Nome { get; set; }
        public string? Biografia { get; set; }
        
    }
}
