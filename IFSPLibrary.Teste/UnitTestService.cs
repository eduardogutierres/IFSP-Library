using AutoMapper;
using IFSPLibrary.domain.Base;
using IFSPLibrary.domain.Entities;
using IFSPLibrary.Repository.Context;
using IFSPLibrary.Repository.Repository;
using IFSPLibrary.Service.Services;
using IFSPLibrary.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPLib";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Autor>, BaseRepository<Autor>>();
            services.AddScoped<IBaseService<Autor>, BaseService<Autor>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Autor, Autor>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Cliente, Cliente>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Editora>, BaseRepository<Editora>>();
            services.AddScoped<IBaseService<Editora>, BaseService<Editora>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Editora, Editora>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Emprestimo>, BaseRepository<Emprestimo>>();
            services.AddScoped<IBaseService<Emprestimo>, BaseService<Emprestimo>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Emprestimo, Emprestimo>(); }).CreateMapper());

            services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Livro, Livro>(); }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestAutor()
        {
            var sp = ConfiguraServices();
            var _autorService = sp.GetService<IBaseService<Autor>>();
            var autor = new Autor
            {
                Nome = "Autor Teste",
                Biografia = "Biografia de teste"
            };

            var result = _autorService?.Add<Autor, Autor, AutorValidator>(autor);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestCliente()
        {
            var sp = ConfiguraServices();
            var _clienteService = sp.GetService<IBaseService<Cliente>>();
            var cliente = new Cliente
            {
                Nome = "Cliente Teste",
                Endereco = "Endereço de teste",
                Email = "cliente@teste.com"
            };

            var result = _clienteService?.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestEditora()
        {
            var sp = ConfiguraServices();
            var _editoraService = sp.GetService<IBaseService<Editora>>();
            var editora = new Editora
            {
                Nome = "Editora Teste",
                Localizacao = "Localização de teste"
            };

            var result = _editoraService?.Add<Editora, Editora, EditoraValidator>(editora);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestEmprestimo()
        {
            var sp = ConfiguraServices();
            var _emprestimoService = sp.GetService<IBaseService<Emprestimo>>();

            // Criar um cliente fictício
            var cliente = new Cliente
            {
                Nome = "Dorival",
                Endereco = "Rua Pedro Cavalo, 336, Birigui-SP",
                Email = "dorival@spfc.fc"
            };

            // Criar um livro fictício
            var livro = new Livro
            {
                Titulo = "Teste",
                Autor = new Autor { Nome = "Junior" },
                AnoPublicacao = 2023,
                Editora = new Editora { Nome = "CDB" }
            };

            // Crie um empréstimo com o cliente 
            var emprestimo = new Emprestimo
            {
                Cliente = cliente,
                Livros = new List<EmprestimoLivro> { new EmprestimoLivro { Livro = livro } },  // Adicione um livro à lista
                DataEmprestimo = DateTime.Now,
                DataDevolucao = DateTime.Now.AddDays(15)
            };

            // Adicione o empréstimo
            var result = _emprestimoService?.Add<Emprestimo, Emprestimo, EmprestimoValidator>(emprestimo);

            // Imprima o resultado 
            Console.WriteLine(JsonSerializer.Serialize(result));
        }



        [TestMethod]
        public void TestLivro()
        {
            var sp = ConfiguraServices();
            var _livroService = sp.GetService<IBaseService<Livro>>();
            var livro = new Livro
            {
                Titulo = "Livro Teste",
                Autor = new Autor(),
                AnoPublicacao = 2023, // Certifique-se de ajustar o ano conforme necessário
                Editora = new Editora()
            };

            var result = _livroService?.Add<Livro, Livro, LivroValidator>(livro);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }

}
