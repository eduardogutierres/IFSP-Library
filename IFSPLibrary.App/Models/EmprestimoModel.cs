using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.App.Models
{
    internal class EmprestimoModel
    {
        public EmprestimoModel()
        {
            Items = new List<EmprestimoItemModel>();
        }
        public int Id { get; set; }
       
        public string Cliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }  
        public List<EmprestimoItemModel> Items { get; set; }
        
    }

    public class EmprestimoItemModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Livro { get; set; }
        public int EmprestimoId { get; set; }
        public int IdLivro { get; internal set; }
        public object Cliente { get; internal set; }
        public object IdCliente { get; internal set; }
    }
}
