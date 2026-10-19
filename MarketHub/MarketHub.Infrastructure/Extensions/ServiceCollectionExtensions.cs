using Cortex.Mediator;
using MarketHub.Domain;
using MarketHub.Domain.Repositories;
using MarketHub.Infrastructure.Data;
using MarketHub.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace MarketHub.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IMediator, Mediator>();

        }
        public static void AddDbContext(this IServiceCollection service, string connectionString, Assembly migrationAssembly)
        {
            service.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString,
                (x) => x.MigrationsAssembly(migrationAssembly)));

        }
    }

}
