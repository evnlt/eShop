using eShop.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Persistence;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetDbConnectionString()));
    }
}