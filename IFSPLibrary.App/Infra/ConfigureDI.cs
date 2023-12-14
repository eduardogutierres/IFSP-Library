using AutoMapper;
using IFSPLibrary.App.Cadastros;
using IFSPLibrary.App.Models;
using IFSPLibrary.domain.Base;
using IFSPLibrary.domain.Entities;
using IFSPLibrary.Repository.Context;
using IFSPLibrary.Repository.Repository;
using IFSPLibrary.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("C:\\Users\\eduar\\OneDrive - ifsp.edu.br\\6\\POEE6\\Eg\\IFSPLib\\IFSPLibrary.App\\Config\\DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Autor>, BaseRepository<Autor>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Editora>, BaseRepository<Editora>>();
            Services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            Services.AddScoped<IBaseRepository<Emprestimo>, BaseRepository<Emprestimo>>();

            // Services
            Services.AddScoped<IBaseService<Autor>, BaseService<Autor>>();
            Services.AddScoped<IBaseService<Editora>, BaseService<Editora>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();
            Services.AddScoped<IBaseService<Emprestimo>, BaseService<Emprestimo>>();

            // Formulários
            Services.AddTransient<CadastroAutor, CadastroAutor>();
            Services.AddTransient<CadastroEditora, CadastroEditora>();
            Services.AddTransient<CadastroLivro, CadastroLivro>();
            Services.AddTransient<CadastroEmprestimo, CadastroEmprestimo>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Autor, AutorModel>();
                config.CreateMap<Editora, EditoraModel>();
                config.CreateMap<Livro, LivroModel>()
                    .ForMember(d => d.NomeAutor, d => d.MapFrom(x => x.Autor.Nome))
                    .ForMember(d => d.NomeEditora, d => d.MapFrom(x => x.Editora.Nome));
                config.CreateMap<Cliente, ClienteModel>();
                config.CreateMap<Emprestimo, EmprestimoModel>()
                .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente.Nome));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
