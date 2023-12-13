namespace eShop.Domain.Products;

public record struct ProductId()
{
    public Guid Value { get; init; } = Guid.NewGuid();
}