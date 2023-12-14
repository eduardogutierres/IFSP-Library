using IFSPLibrary.domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace IFSPLibrary.Teste
{
    [TestClass]
    public class UnitTestLibrary
    {
        [TestMethod]
        public void TesteAutor()
        {
            var autor = new Autor(1, "William Shakespeare", "Biografia vai aqui");

            Console.WriteLine(JsonSerializer.Serialize(autor));
            Assert.AreEqual(autor.Nome, "William Shakespeare");
            Assert.AreEqual(autor.Biografia, "Biografia vai aqui");
        }

        [TestMethod]
        public void TesteCliente()
        {
            var cliente = new Cliente(1, "Alice", "alice@example.com", "123 Rua Principal");

            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Alice");
            Assert.AreEqual(cliente.Email, "alice@example.com");
            Assert.AreEqual(cliente.Endereco, "123 Rua Principal");
        }

        [TestMethod]
        public void TesteEditora()
        {
            var editora = new Editora(1, "Editora X", "Cidade A");

            Console.WriteLine(JsonSerializer.Serialize(editora));
            Assert.AreEqual(editora.Nome, "Editora X");
            Assert.AreEqual(editora.Localizacao, "Cidade A");
        }

        [TestMethod]
        public void TesteEmprestimo()
        {
            // Arrange
            var autor = new Autor(1, "William Shakespeare", "Biografia vai aqui");
            var editora = new Editora(1, "Editora X", "Cidade A");
            var livro = new Livro(1, "Título do Livro", autor, 2022, editora);

            var cliente = new Cliente(1, "Alice", "alice@example.com", "Rua Pedro Cavalo,335, Birigui-SP");

            var emprestimoLivro = new EmprestimoLivro(1, livro, 2); // Alterei a quantidade para 2 para o propósito do teste

            var emprestimo = new Emprestimo(1, DateTime.Today, DateTime.Today.AddDays(14), cliente, new List<EmprestimoLivro> { emprestimoLivro });

            // Act
            var serializedEmprestimo = JsonSerializer.Serialize(emprestimo);

            // Assert
            Assert.AreEqual(emprestimo.DataEmprestimo, DateTime.Today);
            Assert.AreEqual(emprestimo.DataDevolucao, DateTime.Today.AddDays(14));
            Assert.AreEqual(emprestimo.Cliente, cliente);
            Assert.AreEqual(emprestimo.Livros.Count, 1); // Verifica se a quantidade de livros é igual a 1
            Assert.AreEqual(emprestimo.Livros[0].Livro, livro);
            Assert.AreEqual(emprestimo.Livros[0].Quantidade, 2);
        }
    }
}
