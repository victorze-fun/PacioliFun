using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pacioli.Services.Repositories;
using Pacioli.UseCases;
using Pacioli.UseCases.Interfaces.Boundaries;
using Pacioli.UseCases.Interfaces.Repositories;

namespace Pacioli.DesktopUI
{
    public static class IoC
    {
        private static IHost host;

        public static void Init(string[] args)
        {
            host = CreateHostBuilder(args).Build();
        }

        public static T GetService<T>()
        {
            return host.Services.GetRequiredService<T>();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<MainForm>();
                    services.AddTransient<TransactionForm>();

                    services.AddSingleton<IRecordTransaction, RecordTransaction>();
                    services.AddSingleton<ITransactionRepository, TransactionRepository>();
                });
        }
    }
}
