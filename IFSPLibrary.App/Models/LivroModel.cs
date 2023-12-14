using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.App.Models
{
    internal class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string AnoPublicacao { get; set; }
        public string NomeAutor { get; set; }  
        public string NomeEditora { get; set; }
    }
}
