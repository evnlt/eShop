namespace eShop.Domain.Products;

public class Product
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string Name { get; private set; } = string.Empty;

    public Price Price { get; private set; }
}