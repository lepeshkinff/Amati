using Amati.Engine.Services;
using Amati.UI.Engine;
using Microsoft.Extensions.DependencyInjection;

namespace Amati.UI
{
    internal static class Program
    {
        private static IServiceProvider provider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            provider = RegisterServices();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var context = provider.GetRequiredService<AmatiApplicationContext>();
            var loginForm = provider.GetRequiredService<LoginForm>();

            context.MainForm = loginForm;

            Application.Run(context);
        }


        private static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<AmatiApplicationContext>();

            var forms = typeof(LoginForm)
                .Assembly
                .GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Form)))
                .ToList();

            forms.ForEach(x => services.AddTransient(x));

            services.AddTransient(typeof(IDataSource<>), typeof(BaseDataSource<>));
            services.AddTransient<IAuthenticationService, AuthenticationService>();

            var provider = services.BuildServiceProvider();
            return provider;
        }


    }
}