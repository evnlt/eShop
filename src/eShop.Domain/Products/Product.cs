namespace eShop.Domain.Products;

public class Product
{
    public ProductId Id { get; init; } = new();

    public string Name { get; private set; } = string.Empty;

    public Price Price { get; private set; }
}