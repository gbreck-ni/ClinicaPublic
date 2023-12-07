using ClinicaPublic.Repositories;
using ClinicaPublic.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicaPublic
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
            //Application.Run(new FormExamen());
            
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IExamenRepository, ExamenRepository>();
            services.AddScoped<IExamenService, ExamenService>();
            services.AddScoped<ClinicaContext, ClinicaContext>();
            services.AddScoped<FormExamen>();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<FormExamen>();
                Application.Run(form);
            }
        }
    }
}