namespace eShop.Domain.Products;

public record struct ProductId
{
    public Guid Value { get; init; }

    public ProductId(Guid value)
    {
        Value = value;
    }
}