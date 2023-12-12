namespace eShop.Domain.Products;

public record ProductId
{
    public Guid Value { get; init; } = Guid.NewGuid();
}