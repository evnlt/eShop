using eShop.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace eShop.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        builder.ApplyConfiguration(new CustomerConfiguration());
        builder.ApplyConfiguration(new LineItemConfiguration());
        builder.ApplyConfiguration(new OrderConfiguration());
        builder.ApplyConfiguration(new ProductConfiguration());
    }
}