using ContactManager.App.ViewModels;
using ContactManager.App.Views;
using ContactManager.Infrastructure.InFiles.Repositories;
using ContactManager.UseCases.Repositories;
using ContactManager.UseCases.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ContactManager.App
{
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _serviceProvider = RegisterServices();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var contactsForm = _serviceProvider.GetRequiredService<ContactsForm>();
            Application.Run(contactsForm);
        }

        private static IServiceProvider RegisterServices()
        {
            var serviceCollections = new ServiceCollection();


            serviceCollections.AddScoped<ContactsForm>();
            serviceCollections.AddScoped<ContactDetailForm>();


            serviceCollections.AddScoped<ContactsViewModel>();


            serviceCollections.AddAutoMapper(typeof(MapperClass).Assembly);

            serviceCollections.AddScoped<IContactRepository, ContactInFileRepository>();

            serviceCollections.AddScoped<IContactService, ContactService>();

            return serviceCollections.BuildServiceProvider();
        }
    }
}