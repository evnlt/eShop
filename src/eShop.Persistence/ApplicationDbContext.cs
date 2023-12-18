using eShop.Domain.Customers;
using eShop.Domain.Orders;
using eShop.Domain.Products;
using eShop.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace eShop.Persistence;

public class ApplicationDbContext : DbContext
{

    public DbSet<Customer> Customers { get; init; }
    
    public DbSet<LineItem> LineItems { get; init; }
    
    public DbSet<Order> Orders { get; init; }
    
    public DbSet<Product> Products { get; init; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CustomerConfiguration());
        builder.ApplyConfiguration(new LineItemConfiguration());
        builder.ApplyConfiguration(new OrderConfiguration());
        builder.ApplyConfiguration(new ProductConfiguration());
    }
}