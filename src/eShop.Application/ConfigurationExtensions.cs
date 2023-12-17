using Microsoft.Extensions.Configuration;

namespace eShop.Application;

public static class ConfigurationExtensions
{
    private const string DbConnectionStringKey = "eShopDB";

    public static string GetDbConnectionString(this IConfiguration configuration)
    {
        return configuration.GetConnectionString(DbConnectionStringKey) ?? throw new KeyNotFoundException();
    }
}