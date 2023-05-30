using Bibliotecon.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Bibliotecon.Services;
using Bibliotecon.Models;

namespace Bibliotecon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILivroService, LivroService>()
                .AddSingleton<IExemplarService, ExemplarService>()
                .AddSingleton<ICadastrarEmprestimo, CadastrarEmprestimoService>()
                .AddDbContext<DemoDbContext>()
                .BuildServiceProvider();

            

            Application.Run(new Form1(serviceProvider));
        }

    }
}
