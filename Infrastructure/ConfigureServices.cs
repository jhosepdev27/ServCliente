using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
//            services.AddDbContext<ApplicationDbContext>(options => {
//                options.UseSqlServer(configuration[GlobalConstantHelpers.ITEM_CONNECTION] ?? string.Empty,
//                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
//#if DEBUG
//                options.EnableSensitiveDataLogging();
//#endif
//            });
//            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

//            //  services.AddTransient<ILogService, Oxxo.Cloud.Logging.ConfigureServices>();
//            services.AddTransient<ISyncPersistenceItem, SyncItem>();
//            services.AddTransient<ISupplerCatalog, SupplierCatalog>();
//            services.AddTransient<IStorePlaceRepository, StorePlaceRepository>();
            return services;

        }
    }
}
