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
                .AddTransient<ILivroService, LivroService>()
                .AddTransient<IExemplarService, ExemplarService>()
                .AddDbContext<DemoDbContext>()
                .BuildServiceProvider();

            Application.Run(new Form1(serviceProvider));
        }

    }
}
